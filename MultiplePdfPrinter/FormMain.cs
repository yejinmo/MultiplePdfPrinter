using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace MultiplePdfPrinter
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool InPrint { get; set; } = false;
        private bool RequestStop { get; set; } = false;
        private List<string> PathList { get; set; } = new List<string>();

        private string Language { get; set; } = "zh-cn";

        private Dictionary<string, Dictionary<string, string>> LanguageMap =
        new Dictionary<string, Dictionary<string, string>>
        {
            { "zh-cn", new Dictionary<string, string>
                {
                    { "wait", "等待打印" },
                    { "process", "正在打印" },
                    { "done", "打印完成" },
                    { "error", "打印错误" },
                    { "start", "开始打印" },
                    { "stop", "取消打印" },
                }
            }
        };

        private string GetWord(string key)
        {
            if (LanguageMap.TryGetValue(Language, out var map) &&
                map.TryGetValue(key, out var word))
            {
                return word;
            }
            return key;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            if (InPrint)
            {
                ListViewMain.Enabled = false;
                ComboBoxPrinterList.Enabled = false;
                RequestStop = true;
            }
            else
            {
                ButtonPrint.Text = GetWord("stop");
                InPrint = true;
                Task.Run(() =>
                {
                    PrintAll();
                });
            }
        }

        private void PrintAll()
        {
            var printName = string.Empty;
            ListViewItemCollection printList = null;
            Invoke(new Action(() =>
            {
                printList = ListViewMain.Items;
                printName = ComboBoxPrinterList.Text;
            }));
            if (printList != null)
            {
                List<ListViewItem> itemList = new List<ListViewItem>();
                Invoke(new Action(() =>
                {
                    foreach (ListViewItem item in printList)
                    {
                        itemList.Add(item);
                    }
                }));
                foreach (var item in itemList)
                {
                    if (RequestStop)
                    {
                        RequestStop = false;
                        break;
                    }
                    var flag = false;
                    Invoke(new Action(() =>
                    {
                        var text = item.SubItems[3].Text;
                        if (text == GetWord("done"))
                        {
                            flag = true;
                        }
                        else
                        {
                            item.SubItems[3].Text = GetWord("process");
                        }
                    }));
                    if (flag)
                    {
                        continue;
                    }
                    try
                    {
                        var fullPath = item.Tag as string;
                        using (var pdfdocument = new PdfDocument())
                        {
                            pdfdocument.LoadFromFile(fullPath);
                            pdfdocument.PrintSettings.PrinterName = printName;
                            pdfdocument.Print();
                        }
                        Invoke(new Action(() =>
                        {
                            item.SubItems[3].Text = GetWord("done");
                        }));
                    }
                    catch
                    {
                        Invoke(new Action(() =>
                        {
                            item.SubItems[3].Text = GetWord("error");
                        }));
                    }
                }
            }
            InPrint = false;
            Invoke(new Action(() =>
            {
                ButtonPrint.Text = GetWord("start");
                ListViewMain.Enabled = true;
                ComboBoxPrinterList.Enabled = true;
            }));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadPrinterList();
        }

        private void LoadPrinterList()
        {
            Task.Run(() =>
            {
                var printerList = System.Drawing.Printing.PrinterSettings.InstalledPrinters;
                Invoke(new Action(() =>
                {
                    foreach (var printer in printerList)
                    {
                        ComboBoxPrinterList.Items.Add(printer);
                    }
                    if (ComboBoxPrinterList.Items.Count > 0)
                    {
                        ComboBoxPrinterList.SelectedIndex = 0;
                    }
                }));
            });
        }

        private void ListViewMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void ListViewMain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] handles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                Task.Run(() => ProcessDrop(handles));
            }
            catch
            {

            }
        }

        private void AddFile(string fullPath)
        {
            if (PathList.Contains(fullPath))
            {
                return;
            }
            else
            {
                PathList.Add(fullPath);
                var fileInfo = new FileInfo(fullPath);
                var name = fileInfo.Name;
                var size = fileInfo.Length;
                var time = fileInfo.LastWriteTime;
                Invoke(new Action(() =>
                {
                    var item = new ListViewItem(name)
                    {
                        Tag = fullPath
                    };
                    item.SubItems.Add(BytesToString(size));
                    item.SubItems.Add(time.ToLongDateString());
                    item.SubItems.Add(GetWord("wait"));
                    ListViewMain.Items.Add(item);
                }));
            }
        }

        static string BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        private void ProcessDrop(string[] pathList)
        {
            foreach (var path in pathList)
            {
                try
                {
                    if (File.Exists(path))
                    {
                        if (path.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
                        {
                            AddFile(path);
                        }
                    }
                    else if (Directory.Exists(path))
                    {
                        var allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                        ProcessDrop(allfiles);
                    }
                }
                catch
                {

                }
            }
        }

        private void ListViewMain_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void ListViewMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                foreach (ListViewItem item in ListViewMain.Items)
                {
                    item.Selected = true;
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                foreach(ListViewItem item in ListViewMain.SelectedItems)
                {
                    ListViewMain.Items.Remove(item);
                    PathList.Remove(item.Tag as string);
                }
            }
        }

        private void FormMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yejinmo/MultiplePdfPrinter");
        }
    }
}

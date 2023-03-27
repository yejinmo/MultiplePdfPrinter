using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplePdfPrinter
{
    internal static class Language
    {
        public static Dictionary<string, string> DefineMap { get; set; } =
        new Dictionary<string, string>()
        {
            { "zh", "Chinese" },
            { "en", "English" }
        };

        public static Dictionary<string, Dictionary<string, string>> WordMap { get; set; } =
        new Dictionary<string, Dictionary<string, string>>
        {
            { "Chinese", new Dictionary<string, string>
                {
                    { "title", "PDF批量打印" },
                    { "wait", "等待打印" },
                    { "process", "正在打印" },
                    { "done", "打印完成" },
                    { "error", "打印错误" },
                    { "start", "开始打印" },
                    { "stop", "取消打印" },
                    { "header-filename", "文件名" },
                    { "header-filesize", "文件大小" },
                    { "header-time", "时间" },
                    { "header-status", "状态" },
                    { "menu-action", "操作" },
                    { "menu-option", "选项" },
                    { "menu-clear", "清空" },
                    { "menu-refresh", "刷新打印机列表" },
                    { "menu-topmost", "窗口置顶" },
                    { "menu-language", "语言" },
                    { "menu-about", "关于" },
                }
            },
            { "English", new Dictionary<string, string>
                {
                    { "title", "Pdf Multiple Printer" },
                    { "wait", "wait" },
                    { "process", "process" },
                    { "done", "done" },
                    { "error", "error" },
                    { "start", "Start" },
                    { "stop", "Stop" },
                    { "header-filename", "File name" },
                    { "header-filesize", "File size" },
                    { "header-time", "Last time" },
                    { "header-status", "Status" },
                    { "menu-action", "Action" },
                    { "menu-option", "Option" },
                    { "menu-clear", "Clear" },
                    { "menu-refresh", "Refresh printer list" },
                    { "menu-topmost", "Window topmost" },
                    { "menu-language", "Language" },
                    { "menu-about", "About" },
                }
            }
        };

    }
}
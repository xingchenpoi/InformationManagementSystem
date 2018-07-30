using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 干部信息管理系统
{
    class ReadIni
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(
            string section,      //ini文件中的段落
            string key,         //ini文件中的关键字
            string def,         //无法读取时的默认数值
            StringBuilder retVal,    //读取数值
            int size,               //数值的大小
            string fPath            //ini文件的完整路径和名称
            );

        [DllImport("kernel32")]
        private static extern int WritePrivateProfileString(
            string section,      //ini文件中的段落
            string key,         //ini文件中的关键字
            string val,         //ini文件中的关键字的值
            string fPath            //ini文件的完整路径和名称
            );

        public static string ReadString(string key)
        {
            string fPath = Application.StartupPath + "\\config.ini";
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString("hbs",key,"",temp,1024,fPath);
            return temp.ToString();
        }


        public static void WriteString(string key, string val)
        {
            string fPath = Application.StartupPath + "\\config.ini";
            WritePrivateProfileString("hbs",key,val,fPath);
        }
    }
}

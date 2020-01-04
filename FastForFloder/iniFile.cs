using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace FastForFloder
{
    class iniFile
    {
        [DllImport("kernel32.dll")]
 private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")] 
 private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

       public string Path;
        public iniFile(string path)
        {
            this.Path = path;
        }

        public string iniReadValue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", temp, 255, this.Path);
            return temp.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    public class DirectoryInfo
    {
        public int AmountFile { get; set; }
        public int CurrenFiles { get; set; }
        public DirectoryInfo()
        {
            AmountFile = 0;
            CurrenFiles = Directory.GetFiles(@"D:\Img", "*").Length;
        }
        public bool CheckDirectory()
        {
            AmountFile = Directory.GetFiles(@"D:\Img", "*").Length;
            if (AmountFile > CurrenFiles)
            {
                CurrenFiles = AmountFile;
                return true;
            }
            return false;
        }
    }
}

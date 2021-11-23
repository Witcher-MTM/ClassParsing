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
        public string FavouriteDir { get; set; }
        public DirectoryInfo()
        {
            if (!Directory.Exists(@"C:\ProgramData\ScreenProj\Img"))
            {
                Directory.CreateDirectory(@"C:\ProgramData\ScreenProj\Img");
            }
            AmountFile = 0;
            CurrenFiles = Directory.GetFiles(@"C:\ProgramData\ScreenProj\Img", "*").Length;
            if (!Directory.Exists(@"D:\Favourite"))
            {
                Directory.CreateDirectory(@"D:\Favourite");
            }
            FavouriteDir = @"D:\Favourite";
        }
        public bool CheckDirectory()
        {
           
            AmountFile = Directory.GetFiles(@"C:\ProgramData\ScreenProj\Img", "*").Length;
            if (AmountFile > CurrenFiles)
            {
                CurrenFiles = AmountFile;
                return true;
            }
            return false;
        }
       
    }
}

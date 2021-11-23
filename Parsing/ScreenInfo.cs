using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    public class ScreenInfo
    {
        public Random randID { get; set; }
        public List<string> Letters { get; set; }
        public string RandScreen { get; set; }
        public string DefaultPath { get; set; }
        public string MainDir { get; set; }

        public ScreenInfo()
        {
            randID = new Random();
            Letters = new List<string>();
            if (!Directory.Exists(@"C:\ProgramData\ScreenProj"))
            {
                Directory.CreateDirectory(@"C:\ProgramData\ScreenProj");
                File.WriteAllText(@"C:\ProgramData\ScreenProj\Alp.txt", 
                    "a\nb\nc\nd\ne\nf\ng\nh\ni\nj\nk\nl\nm\nn\no\np\nq\nr\ns\nt\nu\nv\nw\nx\ny\nz");
                Directory.CreateDirectory(@"C:\ProgramData\ScreenProj\Img");
            }
            MainDir = @"C:\ProgramData\ScreenProj";
            DefaultPath = @"C:\ProgramData\ScreenProj\Img";
            File.Create("TheSameSRC.txt").Close();
            InitAlp();
        }
        public void InitScreen()
        {
            bool check = false;
            while (!check)
            {
                RandScreen = string.Empty;
                int choice = 0;
                for (int i = 0; i < 6; i++)
                {
                    choice = randID.Next(1, 3);
                    if (choice == 1)
                    {
                        RandScreen += randID.Next(0, 9).ToString();
                    }
                    if (choice == 2)
                    {
                        RandScreen += Letters[randID.Next(0, Letters.Count)];
                    }
                }
                foreach (var item in File.ReadAllLines("TheSameSRC.txt"))
                {
                   
                    if (item == RandScreen)
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    File.AppendAllText("TheSameSRC.txt", RandScreen + "\n");
                }
                if (File.ReadAllLines("TheSameSRC.txt").Length <= 0)
                {
                    File.AppendAllText("TheSameSRC.txt", RandScreen + "\n");
                    check = true;
                }
                
            }
        }
        public void InitAlp()
        {
            foreach (var item in File.ReadAllLines(@"C:\ProgramData\ScreenProj\Alp.txt"))
            {
                Letters.Add(item.ToLower());
            }
        }
        
    }
}

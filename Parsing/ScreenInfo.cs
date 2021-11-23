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


        public ScreenInfo()
        {
            randID = new Random();
            Letters = new List<string>();
            InitAlp();
        }
        public void InitScreen()
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
        }
        public void InitAlp()
        {
            foreach (var item in File.ReadAllLines("alp.txt"))
            {
                Letters.Add(item.ToLower());
            }
        }
        
    }
}

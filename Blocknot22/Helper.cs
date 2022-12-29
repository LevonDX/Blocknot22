using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknot22
{
    static class Helper
    {
        public static void ShowMenu()
        {
            MenuItems[] menuItems = Enum.GetValues<MenuItems>();

            foreach (MenuItems item in menuItems)
            {
                string strItem = item.ToString().AddSpaceBetween();

                Console.WriteLine($"{(int)item}) {strItem}");
            }
        }
    }
}
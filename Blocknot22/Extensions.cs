using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknot22
{
    public static class Extensions
    {
        /// <summary>
        /// Add space between capital letters of a string
        /// </summary>
        public static string AddSpaceBetween(this string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsUpper(s[i]))
                {
                    stringBuilder.Append(" ");
                }

                stringBuilder.Append(s[i]);
            }

            return stringBuilder.ToString().Trim();
        }

        public static void ShowAllConsole(this Blocknot blocknot)
        {
            foreach (Record record in blocknot)
            {
                Console.WriteLine(record);
            }
        }
    }
}
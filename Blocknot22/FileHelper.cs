using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Blocknot22
{
    internal static class FileHelper
    {
        const string FileName = "Blocknot.txt";

        public static void SaveToFile(this Blocknot blocknot)
        {
            using StreamWriter writer = new StreamWriter(FileName);

            foreach (Record record in blocknot)
            {
                writer.WriteLine(record.ToString());
            }
        }

        public static void LoadFromFile(this Blocknot blocknot)
        {
            using StreamReader streamReader = new StreamReader(FileName);

            Blocknot newBlocknot = new Blocknot();

            string str = "";
            while((str = streamReader.ReadLine()) != null)
            {
                if (String.IsNullOrEmpty(str))
                    continue;

                Record record = Record.Parse(str);
                newBlocknot.Add(record);
            }

            blocknot = newBlocknot;
        }
    }
}
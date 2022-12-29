using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknot22
{
    public class Record
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        #region Constructors
        public Record() : this("", "") { }
        public Record(string name) : this(name, "") { }
        public Record(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        #endregion

        public static Record Parse(string str)
        {
            // name ------ phone

            int indexOfDash = str.IndexOf("-");
            if(indexOfDash == -1)
            {
                throw new ArgumentException("Invalid string format");
            }

            string name = str.Substring(0, indexOfDash).Trim();
            string phone = str.Substring(str.LastIndexOf("-") + 1).Trim();

            return new Record(name, phone);
        }


        public override string ToString()
        {
            return $"{Name}-------{Phone}";
        }
    }
}

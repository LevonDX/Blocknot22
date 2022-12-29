using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blocknot22
{
    public class Blocknot : IEnumerable<Record>
    {
        private List<Record> records;

        public Blocknot()
        {
            records = new List<Record>();
        }

        public void Add(Record record)
        {
            this.records.Add(record);
        }

        public void Remove(Record record)
        {
            this.records.Remove(record);
        }

        public Record GetRecord(string name)
        {
            foreach (Record rec in this.records)
            {
                if(rec.Name == name)
                {
                    return rec;
                }
            }

            return null;
        }

        public IEnumerable<Record> Find(string name)
        {
            foreach (Record record in this)
            {
                if (record.Name.ToLower() == name.ToLower())
                {
                    yield return record;
                }
            }
        }

        #region Enumerator
        public IEnumerator<Record> GetEnumerator()
        {
            foreach (Record item in records)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion 
    }
}
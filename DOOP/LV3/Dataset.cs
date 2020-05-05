using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        
        public Prototype Clone()
        {
            Dataset other = new Dataset();
            var list = new List<List<string>>();
            foreach (List<string> secondList in this.data)
            {
                var secondStringList = new List<string>();
                foreach (string item in secondList)
                {
                    var clone = (string)item.Clone();
                    secondStringList.Add(clone);
                }
                list.Add(secondStringList);
            }
            other.data = list;
            return other;
        }
       
        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public void printDataset()
        {
            foreach(List<string> secondList in this.data)
            {
                foreach(string item in secondList)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }

    }
}

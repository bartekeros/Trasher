using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbishLibrary
{
    public abstract class FileManager
    {     
        protected string CreateFile(string textFileName)
        {
            string fileName = $"{ textFileName }.txt";

            if (File.Exists(fileName) == false)
            {
                File.Create(fileName).Close();
            }

            return Path.GetFullPath(fileName);
        }

        protected void Add(string pathToFile, string entry)
        {
            bool isEntryInList = false;
            var savedEntries = File.ReadAllLines(pathToFile);

            for (int i = 0; i < savedEntries.Length; i++)
            {
                if (savedEntries[i] == entry)
                {
                    isEntryInList = true;
                }
            }

            if (isEntryInList == false)
            {
                File.AppendAllText(pathToFile, entry + Environment.NewLine);
            }
        }

        protected void Remove(string pathToFile, string entry)
        {
            var lines = File.ReadAllLines(pathToFile);

            if (File.ReadAllText(pathToFile).Contains(entry) == true)
            {
                for (int i = 0; i < lines.Count(); i++)
                {
                    if (lines[i] == entry)
                    {
                        lines[i] = "";
                    }
                }
            }

            File.WriteAllLines(pathToFile, lines.Where(l => string.IsNullOrWhiteSpace(l) == false));
        }

        protected string[] Get(string pathToFile)
        {
            List<string> output = new List<string>();

            foreach (string entry in File.ReadAllLines(pathToFile))
            {
                output.Add(entry);
            }

            return output.ToArray();
        }
    }
}

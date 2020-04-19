using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubbishLibrary
{
    public class PatternsManager : FileManager
    {
        public string PathToFile { get; private set; }

        public PatternsManager()
        {
            PathToFile = CreateFile("patterns");
        }

        public void AddPattern(string pattern)
        {
            Add(PathToFile, pattern);
        }

        public void RemovePath(string pattern)
        {
            Remove(PathToFile, pattern);
        }

        public string[] GetPatterns()
        {
            return Get(PathToFile);
        }
    }
}

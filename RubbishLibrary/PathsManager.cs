using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RubbishLibrary
{
    public class PathsManager : FileManager
    {
        public string PathToFile { get; private set; }

        public PathsManager()
        {
           PathToFile = CreateFile("paths");
        }

        public void AddPath(string path)
        {
            Add(PathToFile, path);
        }

        public void RemovePath(string path)
        {
            Remove(PathToFile, path);
        }

        public string[] GetPaths()
        {
            return Get(PathToFile);
        }
    }
}

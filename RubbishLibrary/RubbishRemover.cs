using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace RubbishLibrary
{
    public class RubbishRemover
    {
        public void RemoveRubbish(List<string> paths)
        {
            bool IsFileOpen = false;

            for (int i = 0; i < paths.Count; i++)
            {
                try
                {
                    File.Delete(paths[i]);
                }
                catch
                {
                    IsFileOpen = true;
                }
            }

            if (IsFileOpen == true)
            {
                MessageBox.Show("Mostly done, but those files are curently used/open");
            }
            else
            {
                MessageBox.Show("Done :-)");
            }
        }

        public void RemoveRubbish(List<string> paths, bool removeEmptyDirectories, PathsManager pathsManager)
        {
            RemoveRubbish(paths);

            if (removeEmptyDirectories == true)
            {
                RemoveEmptyDirectories(pathsManager.GetPaths().ToList());
            }
        }

        public IEnumerable<string> FindRubbish(List<string> paths, List<string> patterns)
        {
            Stack<string> rootPaths = new Stack<string>();

            foreach (string path in paths)
            {
                rootPaths.Push(path);
            }

            while (rootPaths.Count != 0)
            {
                var path = rootPaths.Pop();
                List<string> next = new List<string>();

                foreach (string pattern in patterns)
                {
                    try
                    {
                        next.AddRange(Directory.GetFiles(path, $"*{ pattern }*"));
                    }
                    catch { }
                }

                if (next != null && next.Count != 0)
                    foreach (var file in next) yield return file;
                try
                {
                    next.AddRange(Directory.GetDirectories(path));
                    foreach (var subdir in next) rootPaths.Push(subdir);
                }
                catch { }
            }
        }

        private void RemoveEmptyDirectories(List<string> rootPaths)
        {
            Stack<string> rootPathsStack = new Stack<string>();
            int deletedFoldersCount = 0;

            foreach (string path in rootPaths)
            {
                rootPathsStack.Push(path);
            }

            while (rootPathsStack.Count != 0)
            {
                string path = rootPathsStack.Pop();

                try
                {
                    if (Directory.GetFiles(path).Length == 0
                        && Directory.GetDirectories(path).Length == 0)
                    {
                        Directory.Delete(path, false);
                        deletedFoldersCount += 1;
                    }
                    else
                    {
                        PushNewDirectoriesToStack(rootPathsStack, path);
                    }
                }
                catch 
                {
                    PushNewDirectoriesToStack(rootPathsStack, path);
                }
            }

            MessageBox.Show($"Deleted folders count: { deletedFoldersCount }");
        }

        private static void PushNewDirectoriesToStack(Stack<string> rootPathsStack, string path)
        {
            if (Directory.Exists(path))
            {
                foreach (string item in Directory.GetDirectories(path))
                {
                    rootPathsStack.Push(item);
                }
            }
        }
    }
}

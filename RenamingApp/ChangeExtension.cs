using System;
using System.Collections.Generic;
using System.IO;

namespace RenamingApp
{
    internal class ChangeExtension
    {
        // Processes the file list passed from Rename_Click method, converts to a FileInfo list and feeds into RenameFiles method
        public static List<string> InputFiles(List<string> fileSet, string textBoxText)
        {
            var renamedList = new List<string>();
            foreach (var t in fileSet)
            {
                var fi = new FileInfo(t);
                var nw = new FileInfo[] { fi };
                renamedList.AddRange(RenameFiles(nw, textBoxText));
            }
            return renamedList;
        }

        // Changes file's extension to the string variable 'extension' passed in from the form's UI
        private static IEnumerable<string> RenameFiles(FileInfo[] info, string extension)
        {
            var filesOut = new List<string>();
            foreach (var f in info)
            {
                try
                {
                    var filePath = f.FullName;
                    var ext = Path.GetExtension(filePath);
                    var result = Path.ChangeExtension(filePath, extension);
                    File.Move(f.FullName, result);
                    // Adds changed name and file directory to filesOut list
                    filesOut.Add(result);
                }
                catch (Exception)
                {
                    filesOut.Add(f.FullName);
                    continue;
                }
            }
            return filesOut;
        }
    }
}


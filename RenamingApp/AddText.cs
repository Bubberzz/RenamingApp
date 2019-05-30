using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenamingApp
{
    internal class AddText
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

        private static IEnumerable<string> RenameFiles(FileInfo[] info, string prefix)
        {
            var filesOut = new List<string>();
            foreach (var f in info)
            {
                try
                {
                    var filename = f.Name;
                    var fullname = f.Directory + "\\" + prefix + filename;
                    File.Move(f.FullName, fullname);              
                    filesOut.Add(fullname);
                }
                catch (Exception ex)
                {
                    filesOut.Add(f.FullName);
                    continue;
                }
            }
            return filesOut;
        }
    }
}

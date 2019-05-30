using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RenamingApp
{
    internal class RemoveText
    {
        // Processes the file list passed from Rename_Click method, converts to a FileInfo list and feeds into RenameFiles method
        public static List<string> InputFiles(List<string> fileSet, string textBoxText, int instance)
        {
            var renamedList = new List<string>();
            foreach (var t in fileSet)
            {
                var fi = new FileInfo(t);
                var nw = new FileInfo[] { fi };
                renamedList.AddRange(RenameFiles(nw, textBoxText, instance));
            }
            return renamedList;
        }

        // Removes file name text starting from a character passed in from the forms text box
        private static IEnumerable<string> RenameFiles(FileInfo[] info, string removeText, int instance)
        {
            var filesOut = new List<string>();
            foreach (var f in info)
            {
                try
                {
                    var filename = "";
                    var fullname = "";
                    // This switch statement will check for a character based on instance selected i.e. 1st '&' in file name
                    switch (instance)
                    {
                        case 0:
                            filename = f.Name.Substring(0, f.Name.IndexOf(removeText, StringComparison.Ordinal));
                            fullname = f.Directory + "\\" + filename;
                            break;
                        case 1:
                            filename = f.Name.Substring(0, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText) +1));
                            fullname = f.Directory + "\\" + filename;
                            break;
                        case 2:
                            filename = f.Name.Substring(0, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText) +1) + 1));
                            fullname = f.Directory + "\\" + filename;
                            break;
                        case 3:
                            filename = f.Name.Substring(0, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText, f.Name.IndexOf(removeText) +1) + 1) + 1));
                            fullname = f.Directory + "\\" + filename;
                            break;
                        default:
                        {
                            break;
                        }
                    }
                  
                    // Checks for duplicates, option to delete duplicates or ignore (won't be renamed)
                    if (File.Exists(fullname))
                    {
                        var dialogResult = MessageBox.Show("Remove duplicates?", "There are duplicate file names", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            f.Delete();
                            continue;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            break;
                        }
                    }

                    // This function renames the file with new name (filename) does not include directory path
                    File.Move(f.FullName, f.FullName.Replace(f.Name, filename));
                    
                    // Adds changed name with file directory path to filesOut list
                    filesOut.Add(fullname);
                }
                //Catches file exceptions i.e. if '&' doesn't exist in string
                catch (Exception ex)
                {
                    MessageBox.Show($"The character '{removeText}' doesn't exist in one or more file names","Warning");
                    filesOut.Add(f.FullName);
                    continue;
                }
            }
            return filesOut;
        }
    }
}


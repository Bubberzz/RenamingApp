using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace RenamingApp
{
    public sealed partial class Form1 : Form
    {
        // Lists for incoming (unprocessed) and outgoing (processed) files
        private readonly List<string> _filesIn = new List<string>();
        private readonly List<string> _filesOut = new List<string>();

        // Initialization of form components
        public Form1()
        {
            InitializeComponent();
            this.Font = new Font(this.Font.FontFamily, 1.1f * this.Font.Size);
            comboBoxOptions.Items.Add("Change extension");
            comboBoxOptions.Items.Add("Remove text after a character");
            comboBoxOptions.Items.Add("Add text in front of filename");
            comboBoxInstance.Items.Add("1st");
            comboBoxInstance.SelectedIndex = 0;
            comboBoxInstance.Items.Add("2nd");
            comboBoxInstance.Items.Add("3rd");
            comboBoxInstance.Items.Add("4th");
            comboBoxInstance.Visible = false;
            labelDescription.Visible = false;
            labelInstance.Visible = false;
            textBoxInput.Visible = false;
        }

        // Open button - opens a file select dialog and loads files into _filesIn list and passes it to ListViewUI method
        private void Open_Click(object sender, EventArgs e)
        {
            _filesIn.Clear();
            listViewDisplay.Items.Clear();
            using (var open = new OpenFileDialog() {ValidateNames = true, Multiselect = true, Title = "Select Files" })
            {
                if (open.ShowDialog() != DialogResult.OK) return;
                foreach (var files in open.FileNames)
                {
                    var file = new FileInfo(files);
                    _filesIn.Add(file.FullName);
                }
                ListViewUI(_filesIn);
            }
        }

        // Displays file names in the user interface from a list passed to it from other methods
        private void ListViewUI(List<string> list)
        {
            foreach (var f in list)
            {
                var fi = new FileInfo(f);
                var item = new ListViewItem(fi.Name);
                item.SubItems.Add(fi.FullName);
                listViewDisplay.Items.Add(item);
            }
        }

        // Rename button - calls methods in other classes based on the option selected in the drop down menu
        private void Rename_Click(object sender, EventArgs e)
        {
            switch (comboBoxOptions.SelectedIndex)
            {
                case 0:
                    _filesOut.Clear();
                    listViewDisplay.Items.Clear();
                    var changedExtFiles = ChangeExtension.InputFiles(_filesIn, textBoxInput.Text);
                    _filesIn.Clear();
                    foreach (var f in changedExtFiles)
                    {
                        var fi = new FileInfo(f);
                        _filesOut.Add(fi.FullName);
                        _filesIn.Add(fi.FullName);
                    }
                    ListViewUI(_filesOut);
                    break;
                case 1:
                    _filesOut.Clear();
                    listViewDisplay.Items.Clear();
                    var shortenedFiles = RemoveText.InputFiles(_filesIn, textBoxInput.Text, comboBoxInstance.SelectedIndex);
                    _filesIn.Clear();
                    foreach (var f in shortenedFiles)
                    {
                        var fi = new FileInfo(f);
                        _filesOut.Add(fi.FullName);
                        _filesIn.Add(fi.FullName);
                    }
                    ListViewUI(_filesOut);
                    break;
                case 2:
                    _filesOut.Clear();
                    listViewDisplay.Items.Clear();
                    var renamedFiles = AddText.InputFiles(_filesIn, textBoxInput.Text);
                    _filesIn.Clear();
                    foreach (var f in renamedFiles)
                    {
                        var fi = new FileInfo(f);
                        _filesOut.Add(fi.FullName);
                        _filesIn.Add(fi.FullName);
                    }
                    ListViewUI(_filesOut);
                    break;
                default:
                    break;
            }
        }

        // This method changes visible UI components based on the selected item from the Options drop down menu
        private void ComboBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOptions.SelectedIndex == comboBoxOptions.FindStringExact("Change extension"))
            {
                labelDescription.Text = @"Type in a new extension e.g .xml";
                labelDescription.Visible = true;
                textBoxInput.Left = 225;
                textBoxInput.Visible = true;
                labelInstance.Visible = false;
                comboBoxInstance.Visible = false;
                textBoxInput.Clear();
            }
            else if (comboBoxOptions.SelectedIndex == comboBoxOptions.FindStringExact("Remove text after a character"))
            {
                labelDescription.Text = @"Remove text starting with this character:";
                labelDescription.Visible = true;
                labelInstance.Visible = true;
                textBoxInput.Left = 262;
                textBoxInput.Visible = true;
                comboBoxInstance.Visible = true;
                textBoxInput.Clear();
            }
            else if (comboBoxOptions.SelectedIndex == comboBoxOptions.FindStringExact("Add text in front of filename"))
            {
                labelDescription.Text = @"Add this text:";
                textBoxInput.Left = 107;
                labelDescription.Visible = true;
                textBoxInput.Visible = true;
                labelInstance.Visible = false;
                comboBoxInstance.Visible = false;
                textBoxInput.Clear();
            };
        }

        // This method allows files to be drag/dropped into the form
        private void ListView_DragDrop(object sender, DragEventArgs e)
        {
            _filesIn.Clear();
            listViewDisplay.Items.Clear();
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var f in files)
            {
                var fi = new FileInfo(f);
                _filesIn.Add(fi.FullName);
            }
            ListViewUI(_filesIn);
        }

        // Drag/Drop mouse effect
        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VHPSerienummerPrinter.Forms;
using VHPSerienummerPrinter;
using VHPSerienummerPrinter.RecentlyOpenedFiles;
using VHPSierienummerPrinter.Forms;

namespace VHPSerienummerPrinter
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                LoadSerienummersForm(args[1]);
                PrintingEnabled(true);
            }
        }

        void labels_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrintingEnabled(false);
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Csv Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadSerienummersForm(openFileDialog.FileName);
                PrintingEnabled(true);
            }            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.MdiParent = this;
            settingsForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void PrintingEnabled(bool enable)
        {
            printToolStripMenuItem.Enabled = enable;
            printPreviewToolStripMenuItem.Enabled = enable;
            printToolStripButton.Enabled = enable;
            printPreviewToolStripButton.Enabled = enable;
        }

        private void LoadSerienummersForm(string path)
        {
            Serienummers serienummers = new Serienummers(path);
            if (serienummers.LoadSuccesful)
            {
                serienummers.MdiParent = this;
                serienummers.FormClosed += new FormClosedEventHandler(labels_FormClosed);
                serienummers.Show();
            }
            else
            {
                serienummers.Dispose();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            Serienummers labels = ActiveMdiChild as Serienummers;
            if (labels != null)
                labels.Print();
        }

        private void PrintPreview()
        {
            Serienummers labels = ActiveMdiChild as Serienummers;
            if (labels != null)
                labels.PrintPreview();
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreview();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowRecentlyOpenedFiles();
        }

        private void ShowRecentlyOpenedFiles()
        {
            RecentFiles recentFiles = RecentFilesHandler.GetRecentlyOpenedFiles();
            if (recentFiles != null)
            {
                foreach (RecentFile file in recentFiles)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(file.FileName);
                    item.Click += item_Click;
                    fileMenu.DropDownItems.Add(item);
                }
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            LoadSerienummersForm(item.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about=new About();
            about.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Csv Files (*.csv)|*.csv|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                LoadSerienummersForm2(openFileDialog.FileName);
                PrintingEnabled(true);
            }    
        }

        private void LoadSerienummersForm2(string path)
        {
            Serienummers2 serienummers = new Serienummers2(path);
            if (serienummers.LoadSuccesful)
            {
                serienummers.MdiParent = this;
                serienummers.FormClosed += new FormClosedEventHandler(labels_FormClosed);
                serienummers.Show();
            }
            else
            {
                serienummers.Dispose();
            }
        }
    }
}

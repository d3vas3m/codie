using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TabTextEdit
{

    public partial class Codie : Form
    {
        public int tabPageCounter = 0;
        public CodieTabPageEditor[] tabPages = new CodieTabPageEditor[100];
        private string fileType, path, arguments, opArgs1 = String.Empty,opArgs2=String.Empty;
        private Dictionary<string, string> langCompileMode = new Dictionary<string, string>() { { "cpp", "g++" }, { "py", "C:\\Python27\\python.exe" }, { "c", "gcc" }, { "js", "C:\\node.exe" } };

        private CodieTabPageEditor tmpTabPage;
        public Codie()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTabPage("untitled");
        }

        private void tEdit_Load(object sender, EventArgs e)
        {
            tmpTabPage = tabPages[tabPageCounter] = new CodieTabPageEditor();
            tmpTabPage.scintilla = new ScintillaNET.Scintilla();
            tmpTabPage.scintilla.Dock = DockStyle.Fill;
            tmpTabPage.tabPage = tabPage0;
            tmpTabPage.tabPage.Controls.Add(tmpTabPage.scintilla);
            tmpTabPage.configureTabPage();
            this.splitContainer.Panel2Collapsed = true;
        }


        public int currentTab()
        {
            return editTabs.SelectedTab.Name[7] - '0';
        }
        private void saveFile()
        {
            if (tabPages[currentTab()].scintilla.Text != tabPages[currentTab()].originalContent)
            {

                File.WriteAllText(tabPages[currentTab()].curFilePath, tabPages[currentTab()].scintilla.Text);
                tabPages[currentTab()].isDirty = false;
            }
        }

        private void showDesign()
        {
            this.webBrowser.DocumentText = tmpTabPage.scintilla.Text;
        }
        private void checkHtml( object sender, EventArgs e)
        {
            tmpTabPage = this.tabPages[currentTab()];
            if (tmpTabPage.getExtension().Contains("html"))
                this.activateWebView();
        }
        private void activateWebView()
        {
            this.showDesign();
            tabPages[currentTab()].scintilla.TextChanged += new EventHandler(this.refreshView);
        }
        private void refreshView(object sender, EventArgs e)
        {
            this.showDesign();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileType =tabPages[currentTab()].getExtension();
            int extensionLength = fileType.Length;
            if (tabPages[currentTab()].isDirty ||  extensionLength < 1)
            {
                if (extensionLength < 1)
                    saveFileDialog1.ShowDialog();
                else saveFile();
            }
            else
            {
                saveFile();
            }
            if(fileType.Contains("html"))
            {
                this.activateWebView();
                this.splitContainer.Panel2Collapsed = false;
            }
        }
        private void showSaveDialog()
        {
            string fileName = saveFileDialog1.FileName;
            tabPages[currentTab()].originalContent = tabPages[currentTab()].scintilla.Text;
            tabPages[currentTab()].curFilePath = fileName;
            try
            {
                File.WriteAllText(fileName, tabPages[currentTab()].originalContent);
                editTabs.SelectedTab.Text = fileName.Split('\\').Last();
                tabPages[currentTab()].activateHighlight();
                tabPages[currentTab()].isDirty = false;
            }
            catch
            {
                Console.WriteLine("Error Save");
            }
            //ssageBox.Show(editTabs.SelectedTab.Name.Split('-')[1]);
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            showSaveDialog();
        }



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = openFileDialog1.FileName;
            string text = File.ReadAllText(fileName);
            addTabPage(fileName.Split('\\').Last());
            tmpTabPage.scintilla.Text = text;
            tmpTabPage.curFilePath = fileName;
            tmpTabPage.isDirty = false;
            tmpTabPage.activateHighlight();
            fileType = tmpTabPage.getExtension();
            if (fileType.Contains("html"))
            {
                this.activateWebView();
                this.splitContainer.Panel2Collapsed = false;
            }
        }
        private void addTabPage(string text)
        {
            ++tabPageCounter;
            tmpTabPage = tabPages[tabPageCounter] = new CodieTabPageEditor();
            tmpTabPage.tabPage = new TabPage();
            tmpTabPage.tabPage.Name = "tabPage" + String.Format("{0}", tabPageCounter);
            tmpTabPage.tabPage.Text = text;
            editTabs.TabPages.Add(tmpTabPage.tabPage);
            tmpTabPage.scintilla = new ScintillaNET.Scintilla();
            tmpTabPage.scintilla.Dock = DockStyle.Fill;
            editTabs.SelectTab(tmpTabPage.tabPage);
            tmpTabPage.tabPage.Controls.Add(tmpTabPage.scintilla);
            tmpTabPage.configureTabPage();
        }


        private void editTabs_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Brush brush;
            Font f = new Font("Verdana", 8.25f, FontStyle.Bold);
            if (e.Index == this.editTabs.SelectedIndex)
            {
                e.Graphics.FillRectangle(Brushes.MintCream, e.Bounds);
                brush = Brushes.Green;
            }
            else brush = Brushes.Gray;
            e.Graphics.DrawString("X", f, Brushes.Red, e.Bounds.Right - 20, e.Bounds.Top + 6);
            e.Graphics.DrawString(this.editTabs.TabPages[e.Index].Text, f, brush, e.Bounds.Left + 12, e.Bounds.Top + 6);
            e.DrawFocusRectangle();
            this.editTabs.SelectedTab.BackColor = Color.DarkTurquoise;
        }
        private void editTabs_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            for (int i = 0; i < this.editTabs.TabPages.Count; i++)
            {
                Rectangle r = editTabs.GetTabRect(i), closeButton = new Rectangle(r.Right - 15, r.Top + 6, 9, 10);

                if (closeButton.Contains(e.Location))
                {
                    if (this.tabPages[currentTab()].isDirty)
                        if (MessageBox.Show("Do you want to save changes and exit?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes && this.tabPages[currentTab()].getExtension().Length < 1)
                            openFileDialog1.ShowDialog();
                        else saveFile();

                    this.editTabs.SelectedTab.Dispose();
                }
            }
        }
        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpTabPage.activateHighlight();
        }
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpTabPage.activateHighlight();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            showSaveDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodieFindAndReplace findDialog = new CodieFindAndReplace(this);
            findDialog.findRepTabControl.SelectedTab = findDialog.findTab;
            findDialog.ShowDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodieFindAndReplace replaceDialog = new CodieFindAndReplace(this);
            replaceDialog.findRepTabControl.SelectedTab = replaceDialog.replaceTab;
            replaceDialog.ShowDialog();
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = new Font("Consolas", 9);
            if (fd.ShowDialog() == DialogResult.OK)
                this.tabPages[currentTab()].tabPage.Font = fd.Font;
            if(tabPages[currentTab()].getExtension().Length > 1)
                tabPages[currentTab()].activateHighlight();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodieColorEditor colEditor = new CodieColorEditor(this);
            colEditor.ShowDialog();
        }

        private void tEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.runProgram();
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            this.splitContainer.Panel2Collapsed = false;
        }

        private void viewCode_Click(object sender, EventArgs e)
        {
            this.splitContainer.Panel2Collapsed = true;
        }

        private void hTMlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmpTabPage.activateHighlight();
        }
        private void runProgram()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Process pro = new Process();
            path = tmpTabPage.curFilePath;
            fileType = tmpTabPage.getExtension();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            if (fileType.Contains("cpp"))
            {
                opArgs1 = "-std=c++14 ";
                opArgs2 = " -o " + path.Split('.')[0] + " && " + path.Split('.')[0];
            }
            arguments = "/C " + langCompileMode[fileType] + " " + opArgs1 + path + opArgs2+" && pause";
            opArgs1 = opArgs2 = String.Empty;
            startInfo.Arguments = arguments;
            pro.StartInfo = startInfo;
            //MessageBox.Show(arguments);
            try
            {
                //Process.Start(langCompileMode[fileType], arguments);
                //Process run = Process.Start(path.Split('.')[0] + ".exe");
                //Process.Start("cmd.exe", arguments);
                pro.Start();
            }
            catch
            {
                Console.WriteLine("Error compiling");
            }
        }

    }

}

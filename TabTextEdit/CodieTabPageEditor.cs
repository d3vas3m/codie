using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabTextEdit
{
    public class CodieTabPageEditor
    {
        public bool isDirty;
        public string curFilePath = String.Empty, fileExtension = String.Empty, originalContent = String.Empty,
            newContent = String.Empty;
        //private static TabControl editTabs;
        public TabPage tabPage;
        public ScintillaNET.Scintilla scintilla;
        private Dictionary<string, string> fileDict = new Dictionary<string, string>();
        private void initFileDict()
        {
            fileDict.Add("py","python");
            fileDict.Add("cpp","cpp");
            fileDict.Add("html", "html");
            fileDict.Add("js", "js");
        }
        public string getExtension()
        {
            if (curFilePath.Length > 1)
                return curFilePath.Split('.').Last();
            else return "";
        }
        public void activateHighlight()
        {
            fileExtension = getExtension();
            if (fileExtension.Length > 1)
            {
                this.scintilla.ConfigurationManager.Language = fileDict[fileExtension];
                this.scintilla.ConfigurationManager.Configure();
            }
        }

        public void configureTabPage()
        {
            initFileDict();
            this.tabPage.Font = new System.Drawing.Font("Consolas", 11);
            this.tabPage.BorderStyle = BorderStyle.FixedSingle;
            this.tabPage.Padding = new Padding(4);
            this.tabPage.Margin = new Padding(4);
            this.tabPage.UseVisualStyleBackColor = true;
            this.scintilla.Size = new System.Drawing.Size(598, 390);
            this.scintilla.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.scintilla.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.scintilla.TabIndex = 2;
            this.scintilla.Margins[0].Width = 30;
            this.scintilla.IsBraceMatching = false;
            this.scintilla.Indentation.IndentWidth = 4;
            this.scintilla.Indentation.TabWidth = 4;
            this.scintilla.Indentation.SmartIndentType = ScintillaNET.SmartIndent.Simple;
            this.scintilla.Padding = new System.Windows.Forms.Padding(5);
            //this.scintilla.Styles.LineNumber.BackColor = System.Drawing.Color.DarkCyan;
            this.scintilla.Styles.LineNumber.Underline = true;
            this.scintilla.TextChanged += new EventHandler(this.scintilla_TextChanged);
        }

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            this.isDirty = true;
        }
    }
}

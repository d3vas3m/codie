using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabTextEdit
{
    public partial class CodieFindAndReplace : Form
    {
        Codie app;
        private bool found;
        private ScintillaNET.Scintilla tmpEditor;
        private int fpos;
        public CodieFindAndReplace(Codie form)
        {
            this.app = form;
            InitializeComponent();
        }

        private int find()
        {
            
            return tmpEditor.Text.IndexOf(this.findText.Text);
        }

        private void replaceText()
        {
            fpos = find();
            if(fpos != -1)
            {
                
                //MessageBox.Show(fpos.ToString());
                tmpEditor.Text = tmpEditor.Text.Remove(fpos, this.repFindText.Text.Length).Insert(fpos, this.repText.Text);
            }
        }

        private void replaceAll()
        {

        }
        private void findButton_Click(object sender, EventArgs e)
        {
            tmpEditor = this.app.tabPages[this.app.currentTab()].scintilla;
            found = tmpEditor.Text.Contains(this.findText.Text);
            if (found)
            {
                this.findResult.Text = "Text found";
                highlightMatchText(ref tmpEditor);
            }
            else this.findResult.Text = "Text not found";
        }

        private void highlightMatchText(ref ScintillaNET.Scintilla tmpEditor)
        {
            tmpEditor.FindReplace.ClearAllHighlights();
            tmpEditor.Indicators[0].Style = ScintillaNET.IndicatorStyle.RoundBox;
            tmpEditor.Indicators[0].Color = Color.Green;
            foreach (Range r in tmpEditor.FindReplace.FindAll(this.findText.Text))
                r.SetIndicator(0);
        }

        private void findText_TextChanged(object sender, EventArgs e)
        {
            this.findResult.Text = "Enter text to search.";
        }

        private void findCancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                tmpEditor.FindReplace.ClearAllHighlights();
            }
            catch(Exception)
            {
                
            }
            this.Dispose();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            tmpEditor = this.app.tabPages[this.app.currentTab()].scintilla;
            replaceText();
        }
    }
}

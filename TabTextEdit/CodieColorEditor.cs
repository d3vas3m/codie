using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TabTextEdit
{

    public partial class CodieColorEditor : Form
    {

        private static ColorDialog colDialog;
        Codie mainForm;
        public CodieColorEditor(Codie mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void foreColor_Click(object sender, EventArgs e)
        {
            colDialog = new ColorDialog();
            colDialog.AllowFullOpen = true;
            colDialog.ShowDialog();
            foreColor.BackColor = colDialog.Color;
            this.mainForm.tabPages[this.mainForm.currentTab()].scintilla.ForeColor = colDialog.Color;
        }

        private void backColor_Click(object sender, EventArgs e)
        {
            colDialog = new ColorDialog();
            colDialog.AllowFullOpen = true;
            colDialog.ShowDialog();
            backColor.BackColor = colDialog.Color;
            this.mainForm.tabPages[this.mainForm.currentTab()].scintilla.BackColor = colDialog.Color;
        }

    }
}

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
    public partial class CodieSplashScreen : Form
    {
        private Timer t;
        public CodieSplashScreen()
        {
            InitializeComponent();
        }

        private void CodieSplashScreen_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 200;
            t.Start();
            t.Tick += t_Tick;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Codie codie = new Codie();
            codie.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace MultiWiiWinGUI
{
    public partial class frmAbout : Form
    {

        public string sVersionLabel
        {
            get { return this.l_version.Text; }
            set { this.l_version.Text = "Version " + value; }
        }

     


        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

            // Get the version of the current assembly.
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_version_Click(object sender, EventArgs e)
        {

        }
    }
}

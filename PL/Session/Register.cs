using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UgVoteQueen.Common;

namespace UgVoteQueen.PL.Session
{
    public partial class Register : UserControl
    {

        private Panel mainPanel;
        private Login loginPanel;

        public Register()
        {
            InitializeComponent();
        }

        public void SetPanels(Panel mainPanel, Login loginPanel)
        {
            this.mainPanel = mainPanel;
            this.loginPanel = loginPanel;
        }

        private void lLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LLSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils utils = new Utils();
            utils.ReplacePanelContent(mainPanel, loginPanel);
        }
    }
}

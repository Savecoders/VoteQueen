using Microsoft.Win32;
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
    public partial class Login : UserControl
    {
        private Register registerPanel;
        private Panel mainPanel;
        

        public Login()
        {
            InitializeComponent();
        }

        public void SetPanels(Panel mainPanel, Register registerPanel)
        {
            this.mainPanel = mainPanel;
            this.registerPanel = registerPanel;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FlexLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Utils utils = new Utils();
            utils.ReplacePanelContent(mainPanel, registerPanel);
        }
    }
}

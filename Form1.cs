using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hello_World
{
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            //only closes whole thing if used on parent form
            Application.Exit();
  
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            var greeting = "Hello " + txt_name.Text;
            txt_output.Text = greeting;

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text.Length() > 0)
            {
                bttn_nameIn.Hide();
            }
            {
                bttn_nameIn.Show();
            }
            // if kept as "greater than 0", invert, as hide should only be if less than 0
        }

        private void bttn_nameIn_Click(object sender, EventArgs e)
        {
            btn_go.Show();
            txt_output.Show();
            bttn_nameIn.Hide();
            txt_name.Hide();
        }
    }
}

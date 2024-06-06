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
        string greeting = "Hello ";
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
            txt_output.Text = greeting + txt_name.Text + "!";
            //need a wait or pause
            bttn_editInfo.Show();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text.Length > 0)
            {
                bttn_nameIn.Show();
            }
            else
            {
                bttn_nameIn.Hide();
            }
            // if kept as "greater than 0", invert, as hide should only be if less than 0
        }

        private void bttn_nameIn_Click(object sender, EventArgs e)
        {
            btn_go.Show();
            txt_output.Show();
            bttn_nameIn.Hide();
            txt_name.Hide();
            txt_output.Text = greeting + txt_name.Text + "!";
        }

        private void bttn_editInfo_Click(object sender, EventArgs e)
        {
            btn_go.Hide();
            txt_name.Text = string.Empty;
            txt_name.Show();
            bttn_editInfo.Hide();
            txt_output.Text = string.Empty;
            txt_output.Hide();
        }
    }
}

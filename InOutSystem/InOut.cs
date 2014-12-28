using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InOutSystem
{
    public partial class InOut : Form
    {
        public InOut()
        {
            InitializeComponent();
        }

        private void enterClick(object sender, EventArgs e)
        {
            if(checkInput(userID.Text, pw.Text))
            {
                if (!(inRB.Checked) && !(outRB.Checked))
                    MessageBox.Show("Select check in or check out!");
                else
                {
                    if (inRB.Checked)
                        MessageBox.Show(userID.Text + " check in succeed.");
                    else
                        MessageBox.Show(userID.Text + " check out succeed.");

                    userID.Text = "";
                    pw.Text = "";
                    inRB.Checked = false;
                    outRB.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("User ID or password is not correct!");
            }
        }

        public Boolean checkInput(string name, string pw)
        {

            return true;
        }
    }
}

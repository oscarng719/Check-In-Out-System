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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void databaseClick(object sender, EventArgs e)
        {
            Point p = this.Location;
            Database frm = new Database();
            this.Hide();
            frm.Show();
            frm.Location = new Point(p.X, p.Y);
        }

        private void systemClick(object sender, EventArgs e)
        {
            Point p = this.Location;
            InOut frm = new InOut();
            this.Hide();
            frm.Show(this);
            frm.Location = new Point(p.X, p.Y);
        }
    }
}

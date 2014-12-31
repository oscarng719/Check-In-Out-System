using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace InOutSystem
{
    public partial class Report : Form
    {
        public List<User> dataList = new List<User>();
        public List<TimeData> timeList = new List<TimeData>();

        public class User
        {
            public string id { get; set; }
            public string password { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public class TimeData
        {
            public string id { get; set; }
            public string date { get; set; }
            public string checkIn { get; set; }
            public string checkOut { get; set; }
        }

        public Report()
        {
            InitializeComponent();

            string dateTmp = DateTime.Today.ToString();
            String date = dateTmp.Substring(0, 10).Replace("/", "");

            readData(date);
            listView();
        }

        public void listView()
        {
            
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Check In", 150);
            listView1.Columns.Add("Check Out", 150);
            listView1.View = View.Details;

            foreach (var row in timeList)
            {
                ListViewItem listitem = new ListViewItem(row.date);
                listitem.SubItems.Add(row.id);
                listitem.SubItems.Add(row.checkIn);
                listitem.SubItems.Add(row.checkOut);
                listView1.Items.Add(listitem);
            }
        }

        public void readData(String date)
        {
            if (File.Exists(date + ".txt"))
            {
                StreamReader streamReader = new StreamReader(date + ".txt");
                string json = streamReader.ReadToEnd();
                streamReader.Close();

                this.timeList = JsonConvert.DeserializeObject<List<TimeData>>(json);
            }

        }

        private void dateChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            String date = result.ToString().Substring(0, 10).Replace("/", "");

            if (File.Exists(date + ".txt"))
            {
                listView1.Clear();
                readData(date);
                listView();
            }
            else
                MessageBox.Show("There are no record on this date.");
        }

        
    }
}

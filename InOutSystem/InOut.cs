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
    public partial class InOut : Form
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

        public InOut()
        {
            InitializeComponent();
            readData();
        }

        public void readData()
        {
            StreamReader streamReader = new StreamReader("User.txt");
            string json = streamReader.ReadToEnd();

            streamReader.Close();

            this.dataList = JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void enterClick(object sender, EventArgs e)
        {
            if (!(inRB.Checked) && !(outRB.Checked))
                MessageBox.Show("Select check in or check out!");
            else if(checkInput(userID.Text, pw.Text))
            {
                if (inRB.Checked)
                    MessageBox.Show(userID.Text + " check in succeed.");
                else
                    MessageBox.Show(userID.Text + " check out succeed.");

                saveData(userID.Text);
                userID.Text = "";
                pw.Text = "";
                inRB.Checked = false;
                outRB.Checked = false;
            }
            else
            {
                MessageBox.Show("User ID or password is not correct!");
            }
        }

        public Boolean checkInput(string id, string pw)
        {
            foreach (var row in dataList)
            {
                if (row.id.Equals(id) && row.password.Equals(pw))
                    return true;
            }

            return false;
        }

        public void saveData(string id)
        {
            string dateTmp = DateTime.Now.ToString();
            String date = dateTmp.Substring(0, 10).Replace("/", "");

            if (File.Exists(date + ".txt"))
            {
                StreamReader streamReader = new StreamReader(date + ".txt");
                string json = streamReader.ReadToEnd();
                streamReader.Close();

                this.timeList = JsonConvert.DeserializeObject<List<TimeData>>(json);
                
            }


            TimeData tmp = new TimeData();
            Boolean checkExist = false;
            foreach (var row in this.timeList)
            {
                if(row.id.Equals(userID.Text))
                {
                    checkExist = true;
                    if (inRB.Checked)
                        row.checkIn = dateTmp.Substring(11, 11);
                    else
                        row.checkOut = dateTmp.Substring(11, 11);
                }
            }

            if (!checkExist)
            {
                tmp.id = userID.Text;
                tmp.date = dateTmp.Substring(0, 10);

                this.timeList.Add(tmp);
                if (inRB.Checked)
                    tmp.checkIn = dateTmp.Substring(11, 11);
                else
                    tmp.checkOut = dateTmp.Substring(11, 11);
            }
            

           
            string json2 = JsonConvert.SerializeObject(timeList);

            StreamWriter file = new StreamWriter(date+".txt");
            file.Write(json2);

            file.Close();
            this.timeList.Clear();
        }
    }
}

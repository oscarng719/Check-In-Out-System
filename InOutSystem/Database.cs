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
    public partial class Database : Form
    {
        public List<User> dataList;
        Boolean editClicked = false;
        Boolean insertClicked = false;
        int rowIndex;

        public class User
        {
            public string id { get; set; }
            public string password { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }

        public Database()
        {
            InitializeComponent();

            offAll();
            readData();
            listView();
        }

        public void listView()
        {
            offAll();
            listView1.Visible = true;
            insertB.Visible = true;
            deleteB.Visible = true;
            editB.Visible = true;

            listView1.CheckBoxes = true;
            listView1.Columns.Add("Select", 50);
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Password", 100);
            listView1.Columns.Add("First Name", 100);
            listView1.Columns.Add("Last Name", 100);
            listView1.View = View.Details;

            foreach (var row in dataList)
            {
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(row.id);
                listitem.SubItems.Add(row.password);
                listitem.SubItems.Add(row.lastName);
                listitem.SubItems.Add(row.firstName);
                
                listView1.Items.Add(listitem);
            }
        }

        public void readData()
        {
           StreamReader streamReader = new StreamReader("User.txt");
           string json = streamReader.ReadToEnd();

           streamReader.Close();

           this.dataList = JsonConvert.DeserializeObject<List<User>>(json);
        }

        private void insertClick(object sender, EventArgs e)
        {
            insertClicked = true;
            offAll();
            showInputForm();
            
        }

        private void editClick(object sender, EventArgs e)
        {
            if(listView1.CheckedItems.Count == 1)
            {
                editClicked = true;
                offAll();
                showInputForm();

                foreach (ListViewItem checkedItem in listView1.CheckedItems)
                {
                    userID.Text = checkedItem.SubItems[1].Text;
                    pw.Text = checkedItem.SubItems[2].Text;
                    Lname.Text = checkedItem.SubItems[3].Text;
                    Fname.Text = checkedItem.SubItems[4].Text;
                    rowIndex = checkedItem.Index;
                }
            }
            else
            {
                MessageBox.Show("For edit, you only can select 1 row.");
            }
        }

        private void deleteClick(object sender, EventArgs e)
        {
            if (true)
            {
                foreach (ListViewItem checkedItem in listView1.CheckedItems)
                {
                    userID.Text = checkedItem.SubItems[1].Text;
                    pw.Text = checkedItem.SubItems[2].Text;
                    Lname.Text = checkedItem.SubItems[3].Text;
                    Fname.Text = checkedItem.SubItems[4].Text;
                    dataList.RemoveAt(checkedItem.Index);
                }
            }
            saveToFile();
            listView1.Clear();
            listView();
        }

        private void saveClick(object sender, EventArgs e)
        {
            if (userID.Text.Equals("") || pw.Text.Equals("") || Lname.Text.Equals("") || Fname.Text.Equals(""))
            {
                MessageBox.Show("Data can not be empty");
            }
            else
            {
                if (insertClicked)
                {
                    User person = new User();
                    person.id = userID.Text;
                    person.password = pw.Text;
                    person.lastName = Lname.Text;
                    person.firstName = Fname.Text;

                    dataList.Add(person);
                }

                if (editClicked)
                {
                    dataList[rowIndex].id = userID.Text;
                    dataList[rowIndex].password = pw.Text;
                    dataList[rowIndex].lastName = Lname.Text;
                    dataList[rowIndex].firstName = Fname.Text;
                }

                saveToFile();
                insertClicked = false;
                editClicked = false;
                listView1.Clear();
                listView();
            }
        }

        public void offAll()
        {
            listView1.Visible = false;
            insertB.Visible = false;
            deleteB.Visible = false;
            editB.Visible = false;
            saveB.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            userID.Visible = false;
            pw.Visible = false;
            Lname.Visible = false;
            Fname.Visible = false;
            userID.Text = "";
            pw.Text = "";
            Lname.Text = "";
            Fname.Text = "";
        }

        public void showInputForm()
        {
            saveB.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            userID.Visible = true;
            pw.Visible = true;
            Lname.Visible = true;
            Fname.Visible = true;
        }

        public void saveToFile()
        {
            string json = JsonConvert.SerializeObject(dataList);

            StreamWriter file = new StreamWriter("User.txt");
            file.Write(json);

            file.Close();
        }
    }
}

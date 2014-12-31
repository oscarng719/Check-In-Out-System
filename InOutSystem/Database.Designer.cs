namespace InOutSystem
{
    partial class Database
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.insertB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.editB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datebase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 400);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // insertB
            // 
            this.insertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertB.Location = new System.Drawing.Point(65, 53);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(80, 30);
            this.insertB.TabIndex = 2;
            this.insertB.Text = "Insert";
            this.insertB.UseVisualStyleBackColor = true;
            this.insertB.Click += new System.EventHandler(this.insertClick);
            // 
            // deleteB
            // 
            this.deleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteB.Location = new System.Drawing.Point(340, 53);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(80, 30);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteClick);
            // 
            // editB
            // 
            this.editB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editB.Location = new System.Drawing.Point(200, 53);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(80, 30);
            this.editB.TabIndex = 4;
            this.editB.Text = "Edit";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.editClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pw
            // 
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(229, 189);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(150, 29);
            this.pw.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "User ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userID
            // 
            this.userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(229, 139);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(150, 29);
            this.userID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "First Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(229, 290);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(150, 29);
            this.Fname.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(229, 240);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(150, 29);
            this.Lname.TabIndex = 10;
            // 
            // saveB
            // 
            this.saveB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveB.Location = new System.Drawing.Point(340, 353);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(80, 30);
            this.saveB.TabIndex = 14;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveClick);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.editB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.insertB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Database";
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Button saveB;
    }
}
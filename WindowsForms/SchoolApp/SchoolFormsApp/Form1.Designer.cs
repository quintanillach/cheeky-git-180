namespace SchoolFormsApp
{
    partial class Form1
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
            this.SchoolName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.Zip = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Twitter = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.btnTestTeacher = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SchoolName
            // 
            this.SchoolName.AutoSize = true;
            this.SchoolName.Location = new System.Drawing.Point(22, 27);
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.Size = new System.Drawing.Size(74, 13);
            this.SchoolName.TabIndex = 0;
            this.SchoolName.Text = "School Name:";
            this.SchoolName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(25, 64);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(48, 13);
            this.Address.TabIndex = 1;
            this.Address.Text = "Address:";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(25, 99);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(27, 13);
            this.City.TabIndex = 2;
            this.City.Text = "City:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(22, 136);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(35, 13);
            this.State.TabIndex = 3;
            this.State.Text = "State:";
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(22, 172);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(25, 13);
            this.Zip.TabIndex = 4;
            this.Zip.Text = "Zip:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(22, 208);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 5;
            this.Phone.Text = "Phone:";
            // 
            // Twitter
            // 
            this.Twitter.AutoSize = true;
            this.Twitter.Location = new System.Drawing.Point(22, 244);
            this.Twitter.Name = "Twitter";
            this.Twitter.Size = new System.Drawing.Size(42, 13);
            this.Twitter.TabIndex = 6;
            this.Twitter.Text = "Twitter:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 20);
            this.txtPhone.TabIndex = 12;
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(126, 244);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(265, 20);
            this.txtTwitter.TabIndex = 13;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(126, 172);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(265, 20);
            this.txtZip.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(126, 136);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(265, 20);
            this.txtState.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 99);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(265, 20);
            this.txtCity.TabIndex = 9;
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(174, 286);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(170, 23);
            this.btnPushToTest.TabIndex = 15;
            this.btnPushToTest.Text = "Push to Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.BtnPushToTest_Click);
            // 
            // btnTestTeacher
            // 
            this.btnTestTeacher.Location = new System.Drawing.Point(84, 325);
            this.btnTestTeacher.Name = "btnTestTeacher";
            this.btnTestTeacher.Size = new System.Drawing.Size(165, 23);
            this.btnTestTeacher.TabIndex = 16;
            this.btnTestTeacher.Text = "TestTeacher";
            this.btnTestTeacher.UseVisualStyleBackColor = true;
            this.btnTestTeacher.Click += new System.EventHandler(this.BtnTestTeacher_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(266, 325);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(149, 23);
            this.btnTestStudent.TabIndex = 17;
            this.btnTestStudent.Text = "TestStudent";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.BtnTestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnTestTeacher);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Twitter);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.SchoolName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // These are the elements of the Windows Forms Application
        // and provide the form aesthetic

        private System.Windows.Forms.Label SchoolName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Twitter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnPushToTest;
        private System.Windows.Forms.Button btnTestTeacher;
        private System.Windows.Forms.Button btnTestStudent;
    }
}


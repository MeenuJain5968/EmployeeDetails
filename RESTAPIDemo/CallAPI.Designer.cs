namespace RESTAPIDemo
{
    partial class CallAPI
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
            this.GetEmployeeDetails = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.GetByID = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtdelete = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetEmployeeDetails
            // 
            this.GetEmployeeDetails.Location = new System.Drawing.Point(72, 73);
            this.GetEmployeeDetails.Name = "GetEmployeeDetails";
            this.GetEmployeeDetails.Size = new System.Drawing.Size(177, 56);
            this.GetEmployeeDetails.TabIndex = 0;
            this.GetEmployeeDetails.Text = "Get Employee Details";
            this.GetEmployeeDetails.UseVisualStyleBackColor = true;
            this.GetEmployeeDetails.Click += new System.EventHandler(this.GetEmployeeDetails_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(2, 156);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(1173, 325);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(466, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(123, 22);
            this.txtid.TabIndex = 2;
            // 
            // GetByID
            // 
            this.GetByID.Location = new System.Drawing.Point(343, 104);
            this.GetByID.Name = "GetByID";
            this.GetByID.Size = new System.Drawing.Size(123, 23);
            this.GetByID.TabIndex = 3;
            this.GetByID.Text = "Get";
            this.GetByID.UseVisualStyleBackColor = true;
            this.GetByID.Click += new System.EventHandler(this.GetByID_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1076, 103);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert ";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(648, 109);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(60, 17);
            this.Gender.TabIndex = 6;
            this.Gender.Text = "Gender:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(723, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 7;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(723, 107);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(100, 22);
            this.txtgender.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(862, 107);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Status:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(920, 50);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 11;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(920, 104);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 22);
            this.txtstatus.TabIndex = 12;
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(507, 103);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(75, 23);
            this.txtdelete.TabIndex = 13;
            this.txtdelete.Text = "Delete";
            this.txtdelete.UseVisualStyleBackColor = true;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(150, 19);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(99, 22);
            this.txtpage.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Page No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter id to get or delete:";
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.GetByID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.GetEmployeeDetails);
            this.Name = "CallAPI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetEmployeeDetails;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button GetByID;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button txtdelete;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


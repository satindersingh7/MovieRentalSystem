namespace MovieRentalSystem
{
    partial class Issue
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
            this.button1 = new System.Windows.Forms.Button();
            this.CustID = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustID
            // 
            this.CustID.Location = new System.Drawing.Point(147, 50);
            this.CustID.Name = "CustID";
            this.CustID.Size = new System.Drawing.Size(165, 20);
            this.CustID.TabIndex = 33;
            this.CustID.TextChanged += new System.EventHandler(this.CustID_TextChanged);
            // 
            // MovieID
            // 
            this.MovieID.Enabled = false;
            this.MovieID.Location = new System.Drawing.Point(147, 24);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(165, 20);
            this.MovieID.TabIndex = 32;
            // 
            // Phone
            // 
            this.Phone.Enabled = false;
            this.Phone.Location = new System.Drawing.Point(147, 195);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(165, 20);
            this.Phone.TabIndex = 27;
            // 
            // Address
            // 
            this.Address.Enabled = false;
            this.Address.Location = new System.Drawing.Point(147, 128);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(165, 61);
            this.Address.TabIndex = 26;
            // 
            // LastName
            // 
            this.LastName.Enabled = false;
            this.LastName.Location = new System.Drawing.Point(147, 102);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(165, 20);
            this.LastName.TabIndex = 25;
            // 
            // FirstName
            // 
            this.FirstName.Enabled = false;
            this.FirstName.Location = new System.Drawing.Point(147, 76);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(165, 20);
            this.FirstName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Movie ID";
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
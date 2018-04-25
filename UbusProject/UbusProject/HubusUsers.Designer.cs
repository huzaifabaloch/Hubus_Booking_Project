namespace UbusProject
{
    partial class HubusUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox2firstName = new System.Windows.Forms.TextBox();
            this.textBox3_Lastname = new System.Windows.Forms.TextBox();
            this.textBox4PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox5_Email = new System.Windows.Forms.TextBox();
            this.button1Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.lastName,
            this.Phone,
            this.Email});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(678, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone No";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email Address";
            this.Email.Name = "Email";
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ID.Location = new System.Drawing.Point(118, 36);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(143, 22);
            this.textBox1_ID.TabIndex = 1;
            // 
            // textBox2firstName
            // 
            this.textBox2firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2firstName.Location = new System.Drawing.Point(38, 64);
            this.textBox2firstName.Name = "textBox2firstName";
            this.textBox2firstName.Size = new System.Drawing.Size(143, 22);
            this.textBox2firstName.TabIndex = 2;
            // 
            // textBox3_Lastname
            // 
            this.textBox3_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Lastname.Location = new System.Drawing.Point(196, 64);
            this.textBox3_Lastname.Name = "textBox3_Lastname";
            this.textBox3_Lastname.Size = new System.Drawing.Size(143, 22);
            this.textBox3_Lastname.TabIndex = 3;
            // 
            // textBox4PhoneNumber
            // 
            this.textBox4PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4PhoneNumber.Location = new System.Drawing.Point(38, 92);
            this.textBox4PhoneNumber.Name = "textBox4PhoneNumber";
            this.textBox4PhoneNumber.Size = new System.Drawing.Size(143, 22);
            this.textBox4PhoneNumber.TabIndex = 4;
            // 
            // textBox5_Email
            // 
            this.textBox5_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_Email.Location = new System.Drawing.Point(196, 91);
            this.textBox5_Email.Name = "textBox5_Email";
            this.textBox5_Email.Size = new System.Drawing.Size(143, 22);
            this.textBox5_Email.TabIndex = 5;
            // 
            // button1Update
            // 
            this.button1Update.BackColor = System.Drawing.Color.DarkCyan;
            this.button1Update.FlatAppearance.BorderSize = 0;
            this.button1Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Update.ForeColor = System.Drawing.Color.White;
            this.button1Update.Location = new System.Drawing.Point(12, 103);
            this.button1Update.Name = "button1Update";
            this.button1Update.Size = new System.Drawing.Size(136, 42);
            this.button1Update.TabIndex = 7;
            this.button1Update.Text = "Update User";
            this.button1Update.UseVisualStyleBackColor = false;
            this.button1Update.Click += new System.EventHandler(this.button1Update_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(154, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UbusProject.Properties.Resources.download_2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2firstName);
            this.groupBox1.Controls.Add(this.textBox5_Email);
            this.groupBox1.Controls.Add(this.textBox1_ID);
            this.groupBox1.Controls.Add(this.textBox4PhoneNumber);
            this.groupBox1.Controls.Add(this.textBox3_Lastname);
            this.groupBox1.Location = new System.Drawing.Point(307, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // HubusUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "HubusUsers";
            this.Text = "HubusUsers";
            this.Load += new System.EventHandler(this.HubusUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.TextBox textBox2firstName;
        private System.Windows.Forms.TextBox textBox3_Lastname;
        private System.Windows.Forms.TextBox textBox4PhoneNumber;
        private System.Windows.Forms.TextBox textBox5_Email;
        private System.Windows.Forms.Button button1Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
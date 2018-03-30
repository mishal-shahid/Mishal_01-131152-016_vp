namespace vpassignment2
{
    partial class createProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cgpa = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.uni = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sem = new System.Windows.Forms.ComboBox();
            this.dept = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Semester ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Dept.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Uni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter Cgpa";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(303, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 11;
            // 
            // cgpa
            // 
            this.cgpa.Location = new System.Drawing.Point(303, 257);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(100, 22);
            this.cgpa.TabIndex = 13;
            this.cgpa.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(303, 99);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 22);
            this.id.TabIndex = 14;
            // 
            // uni
            // 
            this.uni.Location = new System.Drawing.Point(303, 219);
            this.uni.Name = "uni";
            this.uni.Size = new System.Drawing.Size(100, 22);
            this.uni.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(228, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sem
            // 
            this.sem.FormattingEnabled = true;
            this.sem.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.sem.Location = new System.Drawing.Point(303, 140);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(121, 24);
            this.sem.TabIndex = 22;
            // 
            // dept
            // 
            this.dept.FormattingEnabled = true;
            this.dept.Items.AddRange(new object[] {
            "bsse",
            "bsce",
            "bscs",
            "bsIT",
            "bss",
            "bba"});
            this.dept.Location = new System.Drawing.Point(303, 180);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(121, 24);
            this.dept.TabIndex = 23;
            // 
            // createProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uni);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createProfile";
            this.Text = "Create profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cgpa;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox uni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox sem;
        private System.Windows.Forms.ComboBox dept;
    }
}
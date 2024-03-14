namespace Bus_Reservation_System
{
    partial class RegistrationAsReceptionist
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
            label3 = new Label();
            txt_pass = new TextBox();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            txt_Contact = new TextBox();
            label4 = new Label();
            txt_ConfPass = new TextBox();
            btn_Register = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            calender_Dob = new MonthCalendar();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(168, 467);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(286, 464);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(344, 38);
            txt_pass.TabIndex = 6;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(204, 114);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(286, 111);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(344, 38);
            txt_name.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 176);
            label2.Name = "label2";
            label2.Size = new Size(186, 31);
            label2.TabIndex = 12;
            label2.Text = "Contact Number";
            // 
            // txt_Contact
            // 
            txt_Contact.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contact.Location = new Point(286, 173);
            txt_Contact.Name = "txt_Contact";
            txt_Contact.Size = new Size(344, 38);
            txt_Contact.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 532);
            label4.Name = "label4";
            label4.Size = new Size(202, 31);
            label4.TabIndex = 14;
            label4.Text = "Confirm Password";
            // 
            // txt_ConfPass
            // 
            txt_ConfPass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ConfPass.Location = new Point(286, 529);
            txt_ConfPass.Name = "txt_ConfPass";
            txt_ConfPass.Size = new Size(344, 38);
            txt_ConfPass.TabIndex = 13;
            txt_ConfPass.UseSystemPasswordChar = true;
            // 
            // btn_Register
            // 
            btn_Register.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Register.Location = new Point(387, 570);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(118, 55);
            btn_Register.TabIndex = 15;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(532, 645);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Go to LOGIN page";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(132, 228);
            label5.Name = "label5";
            label5.Size = new Size(148, 31);
            label5.TabIndex = 18;
            label5.Text = "Date of Birth";
            // 
            // calender_Dob
            // 
            calender_Dob.AllowDrop = true;
            calender_Dob.Location = new Point(326, 228);
            calender_Dob.Name = "calender_Dob";
            calender_Dob.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(349, 21);
            label6.Name = "label6";
            label6.Size = new Size(191, 41);
            label6.TabIndex = 20;
            label6.Text = "Registration";
            // 
            // RegistrationAsReceptionist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 714);
            Controls.Add(label6);
            Controls.Add(calender_Dob);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(btn_Register);
            Controls.Add(label4);
            Controls.Add(txt_ConfPass);
            Controls.Add(label2);
            Controls.Add(txt_Contact);
            Controls.Add(label1);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Name = "RegistrationAsReceptionist";
            Text = "RegistrationAsReceptionist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txt_pass;
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private TextBox txt_Contact;
        private Label label4;
        private TextBox txt_ConfPass;
        private Button btn_Register;
        private LinkLabel linkLabel1;
        private Label label5;
        private MonthCalendar calender_Dob;
        private Label label6;
    }
}
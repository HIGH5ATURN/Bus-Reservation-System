namespace Bus_Reservation_System
{
    partial class DriverForm
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
            label2 = new Label();
            txt_Contact = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txt_License = new TextBox();
            label5 = new Label();
            calender_Dob = new MonthCalendar();
            btn_AddDriver = new Button();
            btn_goBack = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 225);
            label3.Name = "label3";
            label3.Size = new Size(186, 31);
            label3.TabIndex = 9;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 151);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // txt_Contact
            // 
            txt_Contact.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contact.Location = new Point(228, 225);
            txt_Contact.Name = "txt_Contact";
            txt_Contact.Size = new Size(344, 38);
            txt_Contact.TabIndex = 7;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(228, 148);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(344, 38);
            txt_name.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(264, 31);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 5;
            label1.Text = "Fill Up The Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(181, 31);
            label4.TabIndex = 11;
            label4.Text = "License Number";
            // 
            // txt_License
            // 
            txt_License.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_License.Location = new Point(228, 301);
            txt_License.Name = "txt_License";
            txt_License.Size = new Size(344, 38);
            txt_License.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 367);
            label5.Name = "label5";
            label5.Size = new Size(148, 31);
            label5.TabIndex = 12;
            label5.Text = "Date of Birth";
            // 
            // calender_Dob
            // 
            calender_Dob.AllowDrop = true;
            calender_Dob.Location = new Point(264, 367);
            calender_Dob.Name = "calender_Dob";
            calender_Dob.TabIndex = 20;
            // 
            // btn_AddDriver
            // 
            btn_AddDriver.BackColor = Color.Turquoise;
            btn_AddDriver.FlatStyle = FlatStyle.Flat;
            btn_AddDriver.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddDriver.Location = new Point(321, 600);
            btn_AddDriver.Name = "btn_AddDriver";
            btn_AddDriver.Size = new Size(160, 42);
            btn_AddDriver.TabIndex = 21;
            btn_AddDriver.Text = "Add Driver";
            btn_AddDriver.UseVisualStyleBackColor = false;
            btn_AddDriver.Click += btn_AddDriver_Click;
            // 
            // btn_goBack
            // 
            btn_goBack.BackColor = SystemColors.ActiveCaption;
            btn_goBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_goBack.Location = new Point(2, 3);
            btn_goBack.Name = "btn_goBack";
            btn_goBack.Size = new Size(148, 47);
            btn_goBack.TabIndex = 22;
            btn_goBack.Text = "go back";
            btn_goBack.UseVisualStyleBackColor = false;
            btn_goBack.Click += btn_goBack_Click;
            // 
            // DriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 666);
            Controls.Add(btn_goBack);
            Controls.Add(btn_AddDriver);
            Controls.Add(calender_Dob);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_License);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Contact);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "DriverForm";
            Text = "DriverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txt_Contact;
        private TextBox txt_name;
        private Label label1;
        private Label label4;
        private TextBox txt_License;
        private Label label5;
        private MonthCalendar calender_Dob;
        private Button btn_AddDriver;
        private Button btn_goBack;
    }
}
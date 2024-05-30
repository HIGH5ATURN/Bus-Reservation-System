namespace Bus_Reservation_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_name = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_Login = new Button();
            link_to_RegForm = new LinkLabel();
            link_AllReceptionistLIst = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(464, 79);
            label1.Name = "label1";
            label1.Size = new Size(119, 41);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(356, 162);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(344, 38);
            txt_name.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(356, 237);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(344, 38);
            txt_pass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(312, 169);
            label2.Name = "label2";
            label2.Size = new Size(38, 31);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(238, 240);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(465, 322);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(118, 55);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // link_to_RegForm
            // 
            link_to_RegForm.AutoSize = true;
            link_to_RegForm.Location = new Point(434, 523);
            link_to_RegForm.Name = "link_to_RegForm";
            link_to_RegForm.Size = new Size(175, 20);
            link_to_RegForm.TabIndex = 6;
            link_to_RegForm.TabStop = true;
            link_to_RegForm.Text = "Register as a Reciptionist";
            link_to_RegForm.LinkClicked += link_to_RegForm_LinkClicked;
            // 
            // link_AllReceptionistLIst
            // 
            link_AllReceptionistLIst.AutoSize = true;
            link_AllReceptionistLIst.Location = new Point(12, 523);
            link_AllReceptionistLIst.Name = "link_AllReceptionistLIst";
            link_AllReceptionistLIst.Size = new Size(139, 20);
            link_AllReceptionistLIst.TabIndex = 8;
            link_AllReceptionistLIst.TabStop = true;
            link_AllReceptionistLIst.Text = "All Receptionist List";
            link_AllReceptionistLIst.LinkClicked += link_AllReceptionistLIst_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 552);
            Controls.Add(link_AllReceptionistLIst);
            Controls.Add(link_to_RegForm);
            Controls.Add(btn_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_pass);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_name;
        private TextBox txt_pass;
        private Label label2;
        private Label label3;
        private Button btn_Login;
        private LinkLabel link_to_RegForm;
        private LinkLabel link_AllReceptionistLIst;
    }
}
namespace Bus_Reservation_System
{
    partial class Form2
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
            btn_Login = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.LightCoral;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(76, 281);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(251, 137);
            btn_Login.TabIndex = 6;
            btn_Login.Text = "Add new driver";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(76, 138);
            button1.Name = "button1";
            button1.Size = new Size(251, 137);
            button1.TabIndex = 7;
            button1.Text = "Add new bus";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(333, 138);
            button2.Name = "button2";
            button2.Size = new Size(251, 137);
            button2.TabIndex = 8;
            button2.Text = "Add new station";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(76, 424);
            button3.Name = "button3";
            button3.Size = new Size(251, 137);
            button3.TabIndex = 9;
            button3.Text = "Add new Route";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(721, 138);
            button4.Name = "button4";
            button4.Size = new Size(320, 137);
            button4.TabIndex = 10;
            button4.Text = "Book Ticket for a passenger";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(253, 50);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 11;
            label1.Text = "Utility";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(829, 50);
            label2.Name = "label2";
            label2.Size = new Size(117, 54);
            label2.TabIndex = 12;
            label2.Text = "Book";
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGreen;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(721, 281);
            button5.Name = "button5";
            button5.Size = new Size(320, 137);
            button5.TabIndex = 13;
            button5.Text = "View Todays Schedules";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 606);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_Login);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button5;
    }
}
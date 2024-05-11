namespace Bus_Reservation_System
{
    partial class Create_Schedule
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
            label1 = new Label();
            btn_Add_Schedule = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmb_SelectRoute = new ComboBox();
            cmb_Driver = new ComboBox();
            cmb_Bus = new ComboBox();
            cmb_DepartureTime = new ComboBox();
            label6 = new Label();
            calender = new MonthCalendar();
            txt_fare = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(229, 23);
            label1.Name = "label1";
            label1.Size = new Size(322, 54);
            label1.TabIndex = 13;
            label1.Text = "Create Schedule";
            // 
            // btn_Add_Schedule
            // 
            btn_Add_Schedule.BackColor = Color.Turquoise;
            btn_Add_Schedule.FlatStyle = FlatStyle.Flat;
            btn_Add_Schedule.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add_Schedule.Location = new Point(307, 703);
            btn_Add_Schedule.Name = "btn_Add_Schedule";
            btn_Add_Schedule.Size = new Size(203, 83);
            btn_Add_Schedule.TabIndex = 12;
            btn_Add_Schedule.Text = "Add new Schedule";
            btn_Add_Schedule.UseVisualStyleBackColor = false;
            btn_Add_Schedule.Click += btn_Add_Schedule_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(66, 99);
            label2.Name = "label2";
            label2.Size = new Size(181, 41);
            label2.TabIndex = 14;
            label2.Text = "Select Route";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(66, 480);
            label3.Name = "label3";
            label3.Size = new Size(152, 41);
            label3.TabIndex = 14;
            label3.Text = "Select Bus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(66, 354);
            label4.Name = "label4";
            label4.Size = new Size(187, 41);
            label4.TabIndex = 15;
            label4.Text = "Select Driver";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(66, 228);
            label5.Name = "label5";
            label5.Size = new Size(315, 41);
            label5.TabIndex = 16;
            label5.Text = "Select Departure Time";
            // 
            // cmb_SelectRoute
            // 
            cmb_SelectRoute.FormattingEnabled = true;
            cmb_SelectRoute.Location = new Point(66, 155);
            cmb_SelectRoute.Name = "cmb_SelectRoute";
            cmb_SelectRoute.Size = new Size(315, 28);
            cmb_SelectRoute.TabIndex = 17;
            // 
            // cmb_Driver
            // 
            cmb_Driver.FormattingEnabled = true;
            cmb_Driver.Location = new Point(66, 411);
            cmb_Driver.Name = "cmb_Driver";
            cmb_Driver.Size = new Size(315, 28);
            cmb_Driver.TabIndex = 18;
            // 
            // cmb_Bus
            // 
            cmb_Bus.FormattingEnabled = true;
            cmb_Bus.Location = new Point(66, 536);
            cmb_Bus.Name = "cmb_Bus";
            cmb_Bus.Size = new Size(315, 28);
            cmb_Bus.TabIndex = 19;
            // 
            // cmb_DepartureTime
            // 
            cmb_DepartureTime.FormattingEnabled = true;
            cmb_DepartureTime.Items.AddRange(new object[] { "07:00", "20:00" });
            cmb_DepartureTime.Location = new Point(66, 292);
            cmb_DepartureTime.Name = "cmb_DepartureTime";
            cmb_DepartureTime.Size = new Size(315, 28);
            cmb_DepartureTime.TabIndex = 20;
            cmb_DepartureTime.SelectedIndexChanged += cmb_DepartureTime_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(445, 228);
            label6.Name = "label6";
            label6.Size = new Size(311, 41);
            label6.TabIndex = 21;
            label6.Text = "Select Departure Date";
            // 
            // calender
            // 
            calender.Location = new Point(461, 278);
            calender.Name = "calender";
            calender.TabIndex = 22;
            // 
            // txt_fare
            // 
            txt_fare.BorderStyle = BorderStyle.FixedSingle;
            txt_fare.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fare.Location = new Point(66, 621);
            txt_fare.Name = "txt_fare";
            txt_fare.Size = new Size(233, 38);
            txt_fare.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(66, 577);
            label8.Name = "label8";
            label8.Size = new Size(76, 41);
            label8.TabIndex = 26;
            label8.Text = "Fare";
            // 
            // Create_Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 816);
            Controls.Add(txt_fare);
            Controls.Add(label8);
            Controls.Add(calender);
            Controls.Add(label6);
            Controls.Add(cmb_DepartureTime);
            Controls.Add(cmb_Bus);
            Controls.Add(cmb_Driver);
            Controls.Add(cmb_SelectRoute);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Add_Schedule);
            Name = "Create_Schedule";
            Text = "Create_Schedule";
            Load += Create_Schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Add_Schedule;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmb_SelectRoute;
        private ComboBox cmb_Driver;
        private ComboBox cmb_Bus;
        private ComboBox cmb_DepartureTime;
        private Label label6;
        private MonthCalendar calender;
        private TextBox txt_fare;
        private Label label8;
    }
}
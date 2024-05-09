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
            btn_AddNewDriver = new Button();
            btn_AddnewBus = new Button();
            btn_AddNewStation = new Button();
            btn_AddNewRoute = new Button();
            btn_BookTicket = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_viewTodaysSchedules = new Button();
            btn_viewAllRoutes = new Button();
            panel1 = new Panel();
            btn_goBack = new Button();
            btn_ViewAllDriver = new Button();
            btn_viewAll_Bus = new Button();
            btn_Add_Schedule = new Button();
            SuspendLayout();
            // 
            // btn_AddNewDriver
            // 
            btn_AddNewDriver.BackColor = Color.LightCoral;
            btn_AddNewDriver.FlatStyle = FlatStyle.Flat;
            btn_AddNewDriver.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddNewDriver.Location = new Point(193, 208);
            btn_AddNewDriver.Name = "btn_AddNewDriver";
            btn_AddNewDriver.Size = new Size(203, 83);
            btn_AddNewDriver.TabIndex = 6;
            btn_AddNewDriver.Text = "Add new driver";
            btn_AddNewDriver.UseVisualStyleBackColor = false;
            btn_AddNewDriver.Click += btn_AddNewDriver_Click;
            // 
            // btn_AddnewBus
            // 
            btn_AddnewBus.BackColor = SystemColors.ActiveCaption;
            btn_AddnewBus.FlatStyle = FlatStyle.Flat;
            btn_AddnewBus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddnewBus.Location = new Point(193, 119);
            btn_AddnewBus.Name = "btn_AddnewBus";
            btn_AddnewBus.Size = new Size(203, 83);
            btn_AddnewBus.TabIndex = 7;
            btn_AddnewBus.Text = "Add new bus";
            btn_AddnewBus.UseVisualStyleBackColor = false;
            btn_AddnewBus.Click += btn_AddnewBus_Click;
            // 
            // btn_AddNewStation
            // 
            btn_AddNewStation.BackColor = SystemColors.Highlight;
            btn_AddNewStation.FlatStyle = FlatStyle.Flat;
            btn_AddNewStation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddNewStation.Location = new Point(193, 386);
            btn_AddNewStation.Name = "btn_AddNewStation";
            btn_AddNewStation.Size = new Size(203, 83);
            btn_AddNewStation.TabIndex = 8;
            btn_AddNewStation.Text = "Add new station";
            btn_AddNewStation.UseVisualStyleBackColor = false;
            btn_AddNewStation.Click += btn_AddNewStation_Click;
            // 
            // btn_AddNewRoute
            // 
            btn_AddNewRoute.BackColor = Color.Turquoise;
            btn_AddNewRoute.FlatStyle = FlatStyle.Flat;
            btn_AddNewRoute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddNewRoute.Location = new Point(193, 297);
            btn_AddNewRoute.Name = "btn_AddNewRoute";
            btn_AddNewRoute.Size = new Size(203, 83);
            btn_AddNewRoute.TabIndex = 9;
            btn_AddNewRoute.Text = "Add new Route";
            btn_AddNewRoute.UseVisualStyleBackColor = false;
            btn_AddNewRoute.Click += btn_AddNewRoute_Click;
            // 
            // btn_BookTicket
            // 
            btn_BookTicket.BackColor = Color.PaleGreen;
            btn_BookTicket.FlatStyle = FlatStyle.Flat;
            btn_BookTicket.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BookTicket.Location = new Point(922, 138);
            btn_BookTicket.Name = "btn_BookTicket";
            btn_BookTicket.Size = new Size(317, 80);
            btn_BookTicket.TabIndex = 10;
            btn_BookTicket.Text = "Book Ticket for a passenger";
            btn_BookTicket.UseVisualStyleBackColor = false;
            btn_BookTicket.Click += btn_BookTicket_Click;
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
            label2.Location = new Point(1010, 50);
            label2.Name = "label2";
            label2.Size = new Size(117, 54);
            label2.TabIndex = 12;
            label2.Text = "Book";
            // 
            // btn_viewTodaysSchedules
            // 
            btn_viewTodaysSchedules.BackColor = Color.PaleGreen;
            btn_viewTodaysSchedules.FlatStyle = FlatStyle.Flat;
            btn_viewTodaysSchedules.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_viewTodaysSchedules.Location = new Point(402, 386);
            btn_viewTodaysSchedules.Name = "btn_viewTodaysSchedules";
            btn_viewTodaysSchedules.Size = new Size(203, 83);
            btn_viewTodaysSchedules.TabIndex = 13;
            btn_viewTodaysSchedules.Text = "View All  Schedules";
            btn_viewTodaysSchedules.UseVisualStyleBackColor = false;
            btn_viewTodaysSchedules.Click += btn_viewTodaysSchedules_Click;
            // 
            // btn_viewAllRoutes
            // 
            btn_viewAllRoutes.BackColor = Color.Turquoise;
            btn_viewAllRoutes.FlatStyle = FlatStyle.Flat;
            btn_viewAllRoutes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_viewAllRoutes.Location = new Point(402, 297);
            btn_viewAllRoutes.Name = "btn_viewAllRoutes";
            btn_viewAllRoutes.Size = new Size(203, 83);
            btn_viewAllRoutes.TabIndex = 14;
            btn_viewAllRoutes.Text = "View All Routes";
            btn_viewAllRoutes.UseVisualStyleBackColor = false;
            btn_viewAllRoutes.Click += btn_viewAllRoutes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Location = new Point(731, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 583);
            panel1.TabIndex = 15;
            // 
            // btn_goBack
            // 
            btn_goBack.BackColor = SystemColors.ActiveCaption;
            btn_goBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_goBack.Location = new Point(1, 2);
            btn_goBack.Name = "btn_goBack";
            btn_goBack.Size = new Size(148, 47);
            btn_goBack.TabIndex = 16;
            btn_goBack.Text = "go back";
            btn_goBack.UseVisualStyleBackColor = false;
            btn_goBack.Click += btn_goBack_Click;
            // 
            // btn_ViewAllDriver
            // 
            btn_ViewAllDriver.BackColor = Color.LightCoral;
            btn_ViewAllDriver.FlatStyle = FlatStyle.Flat;
            btn_ViewAllDriver.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewAllDriver.Location = new Point(402, 208);
            btn_ViewAllDriver.Name = "btn_ViewAllDriver";
            btn_ViewAllDriver.Size = new Size(203, 83);
            btn_ViewAllDriver.TabIndex = 17;
            btn_ViewAllDriver.Text = "View All Registered Driver";
            btn_ViewAllDriver.UseVisualStyleBackColor = false;
            btn_ViewAllDriver.Click += btn_ViewAllDriver_Click;
            // 
            // btn_viewAll_Bus
            // 
            btn_viewAll_Bus.BackColor = Color.GreenYellow;
            btn_viewAll_Bus.FlatStyle = FlatStyle.Flat;
            btn_viewAll_Bus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_viewAll_Bus.Location = new Point(402, 119);
            btn_viewAll_Bus.Name = "btn_viewAll_Bus";
            btn_viewAll_Bus.Size = new Size(203, 83);
            btn_viewAll_Bus.TabIndex = 18;
            btn_viewAll_Bus.Text = "View All Bus";
            btn_viewAll_Bus.UseVisualStyleBackColor = false;
            btn_viewAll_Bus.Click += btn_viewAll_Bus_Click;
            // 
            // btn_Add_Schedule
            // 
            btn_Add_Schedule.BackColor = SystemColors.ActiveCaption;
            btn_Add_Schedule.FlatStyle = FlatStyle.Flat;
            btn_Add_Schedule.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add_Schedule.Location = new Point(193, 475);
            btn_Add_Schedule.Name = "btn_Add_Schedule";
            btn_Add_Schedule.Size = new Size(203, 83);
            btn_Add_Schedule.TabIndex = 19;
            btn_Add_Schedule.Text = "Add a Scedule";
            btn_Add_Schedule.UseVisualStyleBackColor = false;
            btn_Add_Schedule.Click += btn_Add_Schedule_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 662);
            Controls.Add(btn_Add_Schedule);
            Controls.Add(btn_viewAll_Bus);
            Controls.Add(btn_ViewAllDriver);
            Controls.Add(btn_goBack);
            Controls.Add(panel1);
            Controls.Add(btn_viewAllRoutes);
            Controls.Add(btn_viewTodaysSchedules);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_BookTicket);
            Controls.Add(btn_AddNewRoute);
            Controls.Add(btn_AddNewStation);
            Controls.Add(btn_AddnewBus);
            Controls.Add(btn_AddNewDriver);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddNewDriver;
        private Button btn_AddnewBus;
        private Button btn_AddNewStation;
        private Button btn_AddNewRoute;
        private Button btn_BookTicket;
        private Label label1;
        private Label label2;
        private Button btn_viewTodaysSchedules;
        private Button btn_viewAllRoutes;
        private Panel panel1;
        private Button btn_goBack;
        private Button btn_ViewAllDriver;
        private Button btn_viewAll_Bus;
        private Button btn_Add_Schedule;
    }
}
namespace Bus_Reservation_System
{
    partial class TicketBookingForm
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
            dataGridView1 = new DataGridView();
            cmb_selectSeat = new ComboBox();
            label1 = new Label();
            txt_ScheduleID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_Origin = new TextBox();
            label4 = new Label();
            txt_Destination = new TextBox();
            label5 = new Label();
            txt_DeptTime = new TextBox();
            label6 = new Label();
            txt_ArrivalTime = new TextBox();
            label7 = new Label();
            txt_Fare = new TextBox();
            label10 = new Label();
            txt_PassengerPhone = new TextBox();
            label11 = new Label();
            txt_PassengerName = new TextBox();
            label12 = new Label();
            txt_PassengerEmail = new TextBox();
            btn_BookTicket = new Button();
            txt_Driver = new TextBox();
            label8 = new Label();
            txt_BusNo = new TextBox();
            label9 = new Label();
            label13 = new Label();
            txt_Search_Dest = new TextBox();
            btn_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(957, 442);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmb_selectSeat
            // 
            cmb_selectSeat.FormattingEnabled = true;
            cmb_selectSeat.Location = new Point(1073, 748);
            cmb_selectSeat.Name = "cmb_selectSeat";
            cmb_selectSeat.Size = new Size(282, 28);
            cmb_selectSeat.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1073, 716);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 13;
            label1.Text = "Select Seat No";
            // 
            // txt_ScheduleID
            // 
            txt_ScheduleID.BorderStyle = BorderStyle.FixedSingle;
            txt_ScheduleID.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ScheduleID.Location = new Point(1071, 131);
            txt_ScheduleID.Name = "txt_ScheduleID";
            txt_ScheduleID.Size = new Size(282, 36);
            txt_ScheduleID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1071, 100);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 15;
            label2.Text = "Schedule ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1071, 177);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 17;
            label3.Text = "Origin";
            // 
            // txt_Origin
            // 
            txt_Origin.BorderStyle = BorderStyle.FixedSingle;
            txt_Origin.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Origin.Location = new Point(1071, 208);
            txt_Origin.Name = "txt_Origin";
            txt_Origin.Size = new Size(282, 36);
            txt_Origin.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1071, 255);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 19;
            label4.Text = "Destination";
            // 
            // txt_Destination
            // 
            txt_Destination.BorderStyle = BorderStyle.FixedSingle;
            txt_Destination.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Destination.Location = new Point(1071, 286);
            txt_Destination.Name = "txt_Destination";
            txt_Destination.Size = new Size(282, 36);
            txt_Destination.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1071, 335);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 21;
            label5.Text = "DepartureTime";
            // 
            // txt_DeptTime
            // 
            txt_DeptTime.BorderStyle = BorderStyle.FixedSingle;
            txt_DeptTime.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DeptTime.Location = new Point(1071, 366);
            txt_DeptTime.Name = "txt_DeptTime";
            txt_DeptTime.Size = new Size(282, 36);
            txt_DeptTime.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1071, 409);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 23;
            label6.Text = "Arrival Time";
            // 
            // txt_ArrivalTime
            // 
            txt_ArrivalTime.BorderStyle = BorderStyle.FixedSingle;
            txt_ArrivalTime.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ArrivalTime.Location = new Point(1071, 440);
            txt_ArrivalTime.Name = "txt_ArrivalTime";
            txt_ArrivalTime.Size = new Size(282, 36);
            txt_ArrivalTime.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1071, 485);
            label7.Name = "label7";
            label7.Size = new Size(49, 28);
            label7.TabIndex = 25;
            label7.Text = "Fare";
            // 
            // txt_Fare
            // 
            txt_Fare.BorderStyle = BorderStyle.FixedSingle;
            txt_Fare.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Fare.Location = new Point(1071, 516);
            txt_Fare.Name = "txt_Fare";
            txt_Fare.Size = new Size(282, 36);
            txt_Fare.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(35, 639);
            label10.Name = "label10";
            label10.Size = new Size(104, 28);
            label10.TabIndex = 33;
            label10.Text = "Phone No";
            // 
            // txt_PassengerPhone
            // 
            txt_PassengerPhone.BorderStyle = BorderStyle.FixedSingle;
            txt_PassengerPhone.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PassengerPhone.Location = new Point(35, 670);
            txt_PassengerPhone.Name = "txt_PassengerPhone";
            txt_PassengerPhone.Size = new Size(282, 36);
            txt_PassengerPhone.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(35, 562);
            label11.Name = "label11";
            label11.Size = new Size(164, 28);
            label11.TabIndex = 31;
            label11.Text = "Passenger Name";
            // 
            // txt_PassengerName
            // 
            txt_PassengerName.BorderStyle = BorderStyle.FixedSingle;
            txt_PassengerName.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PassengerName.Location = new Point(35, 593);
            txt_PassengerName.Name = "txt_PassengerName";
            txt_PassengerName.Size = new Size(282, 36);
            txt_PassengerName.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(35, 718);
            label12.Name = "label12";
            label12.Size = new Size(60, 28);
            label12.TabIndex = 35;
            label12.Text = "Email";
            // 
            // txt_PassengerEmail
            // 
            txt_PassengerEmail.BorderStyle = BorderStyle.FixedSingle;
            txt_PassengerEmail.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PassengerEmail.Location = new Point(35, 749);
            txt_PassengerEmail.Name = "txt_PassengerEmail";
            txt_PassengerEmail.Size = new Size(282, 36);
            txt_PassengerEmail.TabIndex = 34;
            // 
            // btn_BookTicket
            // 
            btn_BookTicket.BackColor = SystemColors.ActiveCaption;
            btn_BookTicket.FlatStyle = FlatStyle.Flat;
            btn_BookTicket.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BookTicket.Location = new Point(592, 764);
            btn_BookTicket.Name = "btn_BookTicket";
            btn_BookTicket.Size = new Size(203, 83);
            btn_BookTicket.TabIndex = 36;
            btn_BookTicket.Text = "Book The Ticket";
            btn_BookTicket.UseVisualStyleBackColor = false;
            btn_BookTicket.Click += btn_BookTicket_Click;
            // 
            // txt_Driver
            // 
            txt_Driver.BorderStyle = BorderStyle.FixedSingle;
            txt_Driver.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Driver.Location = new Point(1071, 591);
            txt_Driver.Name = "txt_Driver";
            txt_Driver.Size = new Size(282, 36);
            txt_Driver.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1071, 560);
            label8.Name = "label8";
            label8.Size = new Size(66, 28);
            label8.TabIndex = 27;
            label8.Text = "Driver";
            // 
            // txt_BusNo
            // 
            txt_BusNo.BorderStyle = BorderStyle.FixedSingle;
            txt_BusNo.Font = new Font("Siyam Rupali", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BusNo.Location = new Point(1073, 671);
            txt_BusNo.Name = "txt_BusNo";
            txt_BusNo.Size = new Size(282, 36);
            txt_BusNo.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1073, 640);
            label9.Name = "label9";
            label9.Size = new Size(120, 28);
            label9.TabIndex = 29;
            label9.Text = "BusNumber";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(35, 29);
            label13.Name = "label13";
            label13.Size = new Size(210, 28);
            label13.TabIndex = 38;
            label13.Text = "Search By Destination";
            // 
            // txt_Search_Dest
            // 
            txt_Search_Dest.Location = new Point(35, 60);
            txt_Search_Dest.Name = "txt_Search_Dest";
            txt_Search_Dest.Size = new Size(282, 27);
            txt_Search_Dest.TabIndex = 37;
            txt_Search_Dest.TextChanged += txt_Search_Dest_TextChanged_1;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Firebrick;
            btn_Clear.FlatStyle = FlatStyle.Flat;
            btn_Clear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Location = new Point(35, 810);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(104, 51);
            btn_Clear.TabIndex = 39;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = false;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // TicketBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 887);
            Controls.Add(btn_Clear);
            Controls.Add(label13);
            Controls.Add(txt_Search_Dest);
            Controls.Add(btn_BookTicket);
            Controls.Add(label12);
            Controls.Add(txt_PassengerEmail);
            Controls.Add(label10);
            Controls.Add(txt_PassengerPhone);
            Controls.Add(label11);
            Controls.Add(txt_PassengerName);
            Controls.Add(label9);
            Controls.Add(txt_BusNo);
            Controls.Add(label8);
            Controls.Add(txt_Driver);
            Controls.Add(label7);
            Controls.Add(txt_Fare);
            Controls.Add(label6);
            Controls.Add(txt_ArrivalTime);
            Controls.Add(label5);
            Controls.Add(txt_DeptTime);
            Controls.Add(label4);
            Controls.Add(txt_Destination);
            Controls.Add(label3);
            Controls.Add(txt_Origin);
            Controls.Add(label2);
            Controls.Add(txt_ScheduleID);
            Controls.Add(label1);
            Controls.Add(cmb_selectSeat);
            Controls.Add(dataGridView1);
            Name = "TicketBookingForm";
            Text = "TicketBookingForm";
            Load += TicketBookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmb_selectSeat;
        private Label label1;
        private TextBox txt_ScheduleID;
        private Label label2;
        private Label label3;
        private TextBox txt_Origin;
        private Label label4;
        private TextBox txt_Destination;
        private Label label5;
        private TextBox txt_DeptTime;
        private Label label6;
        private TextBox txt_ArrivalTime;
        private Label label7;
        private TextBox txt_Fare;
        private Label label10;
        private TextBox txt_PassengerPhone;
        private Label label11;
        private TextBox txt_PassengerName;
        private Label label12;
        private TextBox txt_PassengerEmail;
        private Button btn_BookTicket;
        private TextBox txt_Driver;
        private Label label8;
        private TextBox txt_BusNo;
        private Label label9;
        private Label label13;
        private TextBox txt_Search_Dest;
        private Button btn_Clear;
    }
}
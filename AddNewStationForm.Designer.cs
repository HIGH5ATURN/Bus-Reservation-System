namespace Bus_Reservation_System
{
    partial class AddNewStationForm
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
            btn_AddStation = new Button();
            label1 = new Label();
            txt_CityName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_AddStation
            // 
            btn_AddStation.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddStation.Location = new Point(176, 232);
            btn_AddStation.Name = "btn_AddStation";
            btn_AddStation.Size = new Size(157, 55);
            btn_AddStation.TabIndex = 9;
            btn_AddStation.Text = "Add Station";
            btn_AddStation.UseVisualStyleBackColor = true;
            btn_AddStation.Click += btn_AddStation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 164);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 8;
            label1.Text = "City Name:";
            // 
            // txt_CityName
            // 
            txt_CityName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CityName.Location = new Point(150, 164);
            txt_CityName.Name = "txt_CityName";
            txt_CityName.Size = new Size(274, 38);
            txt_CityName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(118, 46);
            label3.Name = "label3";
            label3.Size = new Size(283, 41);
            label3.TabIndex = 6;
            label3.Text = "Give Station Name";
            // 
            // AddNewStationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 420);
            Controls.Add(btn_AddStation);
            Controls.Add(label1);
            Controls.Add(txt_CityName);
            Controls.Add(label3);
            Name = "AddNewStationForm";
            Text = "AddNewStationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddStation;
        private Label label1;
        private TextBox txt_CityName;
        private Label label3;
    }
}
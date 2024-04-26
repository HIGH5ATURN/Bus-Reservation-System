namespace Bus_Reservation_System
{
    partial class AddRouteForm
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
            cmb_To = new ComboBox();
            btn_AddRoute = new Button();
            label1 = new Label();
            cmb_From = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btn_GoBack = new Button();
            label4 = new Label();
            txt_distance = new TextBox();
            label5 = new Label();
            txt_Hour = new TextBox();
            label6 = new Label();
            txt_min = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // cmb_To
            // 
            cmb_To.FormattingEnabled = true;
            cmb_To.Location = new Point(380, 200);
            cmb_To.Name = "cmb_To";
            cmb_To.Size = new Size(240, 28);
            cmb_To.TabIndex = 1;
            // 
            // btn_AddRoute
            // 
            btn_AddRoute.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddRoute.Location = new Point(219, 566);
            btn_AddRoute.Name = "btn_AddRoute";
            btn_AddRoute.Size = new Size(192, 55);
            btn_AddRoute.TabIndex = 7;
            btn_AddRoute.Text = "Add Route";
            btn_AddRoute.UseVisualStyleBackColor = true;
            btn_AddRoute.Click += btn_AddRoute_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(186, 79);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 6;
            label1.Text = "Route Information";
            // 
            // cmb_From
            // 
            cmb_From.FormattingEnabled = true;
            cmb_From.Location = new Point(26, 200);
            cmb_From.Name = "cmb_From";
            cmb_From.Size = new Size(240, 28);
            cmb_From.TabIndex = 8;
            cmb_From.SelectedIndexChanged += cmb_From_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 156);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 9;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(380, 156);
            label3.Name = "label3";
            label3.Size = new Size(52, 41);
            label3.TabIndex = 10;
            label3.Text = "To";
            // 
            // btn_GoBack
            // 
            btn_GoBack.BackColor = Color.RosyBrown;
            btn_GoBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_GoBack.Location = new Point(1, 2);
            btn_GoBack.Name = "btn_GoBack";
            btn_GoBack.Size = new Size(135, 42);
            btn_GoBack.TabIndex = 11;
            btn_GoBack.Text = "Go back";
            btn_GoBack.UseVisualStyleBackColor = false;
            btn_GoBack.Click += btn_GoBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(145, 284);
            label4.Name = "label4";
            label4.Size = new Size(103, 31);
            label4.TabIndex = 13;
            label4.Text = "Distance";
            label4.Click += label4_Click;
            // 
            // txt_distance
            // 
            txt_distance.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_distance.Location = new Point(254, 284);
            txt_distance.Name = "txt_distance";
            txt_distance.Size = new Size(135, 38);
            txt_distance.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(181, 414);
            label5.Name = "label5";
            label5.Size = new Size(67, 31);
            label5.TabIndex = 15;
            label5.Text = "Hour";
            // 
            // txt_Hour
            // 
            txt_Hour.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Hour.Location = new Point(254, 411);
            txt_Hour.Name = "txt_Hour";
            txt_Hour.Size = new Size(135, 38);
            txt_Hour.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(194, 470);
            label6.Name = "label6";
            label6.Size = new Size(54, 31);
            label6.TabIndex = 17;
            label6.Text = "Min";
            // 
            // txt_min
            // 
            txt_min.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_min.Location = new Point(254, 467);
            txt_min.Name = "txt_min";
            txt_min.Size = new Size(135, 38);
            txt_min.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(244, 346);
            label7.Name = "label7";
            label7.Size = new Size(145, 41);
            label7.TabIndex = 18;
            label7.Text = "Duration";
            // 
            // AddRouteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 665);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txt_min);
            Controls.Add(label5);
            Controls.Add(txt_Hour);
            Controls.Add(label4);
            Controls.Add(txt_distance);
            Controls.Add(btn_GoBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmb_From);
            Controls.Add(btn_AddRoute);
            Controls.Add(label1);
            Controls.Add(cmb_To);
            Name = "AddRouteForm";
            Text = "AddRouteForm";
            Load += AddRouteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmb_To;
        private Button btn_AddRoute;
        private Label label1;
        private ComboBox cmb_From;
        private Label label2;
        private Label label3;
        private Button btn_GoBack;
        private Label label4;
        private TextBox txt_distance;
        private Label label5;
        private TextBox txt_Hour;
        private Label label6;
        private TextBox txt_min;
        private Label label7;
    }
}
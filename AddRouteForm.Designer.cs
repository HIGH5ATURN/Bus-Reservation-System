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
            btn_AddRoute.Location = new Point(219, 530);
            btn_AddRoute.Name = "btn_AddRoute";
            btn_AddRoute.Size = new Size(192, 55);
            btn_AddRoute.TabIndex = 7;
            btn_AddRoute.Text = "Add Route";
            btn_AddRoute.UseVisualStyleBackColor = true;
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
            // AddRouteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 665);
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
    }
}
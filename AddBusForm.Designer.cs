namespace Bus_Reservation_System
{
    partial class AddBusForm
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
            btn_AddBus = new Button();
            label2 = new Label();
            txt_Bus_Number = new TextBox();
            label1 = new Label();
            txt_capacity = new TextBox();
            label3 = new Label();
            txt_Model = new TextBox();
            btn_return = new Button();
            SuspendLayout();
            // 
            // btn_AddBus
            // 
            btn_AddBus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddBus.Location = new Point(338, 320);
            btn_AddBus.Name = "btn_AddBus";
            btn_AddBus.Size = new Size(118, 55);
            btn_AddBus.TabIndex = 8;
            btn_AddBus.Text = "Add Bus";
            btn_AddBus.UseVisualStyleBackColor = true;
            btn_AddBus.Click += btn_AddBus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 7;
            label2.Text = "Bus Number";
            // 
            // txt_Bus_Number
            // 
            txt_Bus_Number.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Bus_Number.Location = new Point(250, 118);
            txt_Bus_Number.Name = "txt_Bus_Number";
            txt_Bus_Number.Size = new Size(344, 38);
            txt_Bus_Number.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 249);
            label1.Name = "label1";
            label1.Size = new Size(103, 31);
            label1.TabIndex = 10;
            label1.Text = "Capacity";
            // 
            // txt_capacity
            // 
            txt_capacity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_capacity.Location = new Point(250, 249);
            txt_capacity.Name = "txt_capacity";
            txt_capacity.Size = new Size(344, 38);
            txt_capacity.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(126, 182);
            label3.Name = "label3";
            label3.Size = new Size(81, 31);
            label3.TabIndex = 12;
            label3.Text = "Model";
            label3.Click += label3_Click;
            // 
            // txt_Model
            // 
            txt_Model.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Model.Location = new Point(250, 182);
            txt_Model.Name = "txt_Model";
            txt_Model.Size = new Size(344, 38);
            txt_Model.TabIndex = 11;
            // 
            // btn_return
            // 
            btn_return.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_return.Location = new Point(12, 12);
            btn_return.Name = "btn_return";
            btn_return.Size = new Size(118, 38);
            btn_return.TabIndex = 13;
            btn_return.Text = "Go back";
            btn_return.UseVisualStyleBackColor = true;
            btn_return.Click += btn_return_Click;
            // 
            // AddBusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_return);
            Controls.Add(label3);
            Controls.Add(txt_Model);
            Controls.Add(label1);
            Controls.Add(txt_capacity);
            Controls.Add(btn_AddBus);
            Controls.Add(label2);
            Controls.Add(txt_Bus_Number);
            Name = "AddBusForm";
            Text = "AddBusForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddBus;
        private Label label2;
        private TextBox txt_Bus_Number;
        private Label label1;
        private TextBox txt_capacity;
        private Label label3;
        private TextBox txt_Model;
        private Button btn_return;
    }
}
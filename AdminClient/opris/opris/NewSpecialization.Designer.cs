namespace opris
{
    partial class NewSpecialization
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
            this.SaveSpecialization_btn = new System.Windows.Forms.Button();
            this.CancelSpecialization_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameSpecialization_tb = new System.Windows.Forms.TextBox();
            this.SaveCloceSpec_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveSpecialization_btn
            // 
            this.SaveSpecialization_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveSpecialization_btn.Location = new System.Drawing.Point(2, 122);
            this.SaveSpecialization_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveSpecialization_btn.Name = "SaveSpecialization_btn";
            this.SaveSpecialization_btn.Size = new System.Drawing.Size(93, 32);
            this.SaveSpecialization_btn.TabIndex = 2;
            this.SaveSpecialization_btn.Text = "Сохранить";
            this.SaveSpecialization_btn.UseVisualStyleBackColor = true;
            this.SaveSpecialization_btn.Click += new System.EventHandler(this.SaveSpecialization_btn_Click);
            // 
            // CancelSpecialization_btn
            // 
            this.CancelSpecialization_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSpecialization_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelSpecialization_btn.Location = new System.Drawing.Point(260, 122);
            this.CancelSpecialization_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelSpecialization_btn.Name = "CancelSpecialization_btn";
            this.CancelSpecialization_btn.Size = new System.Drawing.Size(93, 32);
            this.CancelSpecialization_btn.TabIndex = 4;
            this.CancelSpecialization_btn.Text = "Отмена";
            this.CancelSpecialization_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование";
            // 
            // NameSpecialization_tb
            // 
            this.NameSpecialization_tb.Location = new System.Drawing.Point(29, 64);
            this.NameSpecialization_tb.Margin = new System.Windows.Forms.Padding(4);
            this.NameSpecialization_tb.Name = "NameSpecialization_tb";
            this.NameSpecialization_tb.Size = new System.Drawing.Size(306, 25);
            this.NameSpecialization_tb.TabIndex = 1;
            // 
            // SaveCloceSpec_btn
            // 
            this.SaveCloceSpec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveCloceSpec_btn.Location = new System.Drawing.Point(103, 122);
            this.SaveCloceSpec_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveCloceSpec_btn.Name = "SaveCloceSpec_btn";
            this.SaveCloceSpec_btn.Size = new System.Drawing.Size(149, 32);
            this.SaveCloceSpec_btn.TabIndex = 3;
            this.SaveCloceSpec_btn.Text = "Сохранить и закрыть";
            this.SaveCloceSpec_btn.UseVisualStyleBackColor = true;
            this.SaveCloceSpec_btn.Click += new System.EventHandler(this.SaveCloceSpec_btn_Click);
            // 
            // NewSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(355, 180);
            this.Controls.Add(this.SaveCloceSpec_btn);
            this.Controls.Add(this.NameSpecialization_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelSpecialization_btn);
            this.Controls.Add(this.SaveSpecialization_btn);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewSpecialization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Специализация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveSpecialization_btn;
        private System.Windows.Forms.Button CancelSpecialization_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameSpecialization_tb;
        private System.Windows.Forms.Button SaveCloceSpec_btn;
    }
}
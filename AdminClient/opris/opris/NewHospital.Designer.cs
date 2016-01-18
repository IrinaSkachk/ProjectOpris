namespace opris
{
    partial class NewHospital
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
            this.NameClinic_tb = new System.Windows.Forms.TextBox();
            this.AddressClinic_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveHospital_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SaveCloseHospital_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameClinic_tb
            // 
            this.NameClinic_tb.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameClinic_tb.Location = new System.Drawing.Point(155, 37);
            this.NameClinic_tb.Name = "NameClinic_tb";
            this.NameClinic_tb.Size = new System.Drawing.Size(241, 25);
            this.NameClinic_tb.TabIndex = 0;
            // 
            // AddressClinic_tb
            // 
            this.AddressClinic_tb.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressClinic_tb.Location = new System.Drawing.Point(154, 68);
            this.AddressClinic_tb.Multiline = true;
            this.AddressClinic_tb.Name = "AddressClinic_tb";
            this.AddressClinic_tb.Size = new System.Drawing.Size(241, 82);
            this.AddressClinic_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес";
            // 
            // SaveHospital_btn
            // 
            this.SaveHospital_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveHospital_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveHospital_btn.Location = new System.Drawing.Point(25, 180);
            this.SaveHospital_btn.Name = "SaveHospital_btn";
            this.SaveHospital_btn.Size = new System.Drawing.Size(101, 43);
            this.SaveHospital_btn.TabIndex = 2;
            this.SaveHospital_btn.Text = "Сохранить";
            this.SaveHospital_btn.UseVisualStyleBackColor = true;
            this.SaveHospital_btn.Click += new System.EventHandler(this.SaveHospital_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_btn.Location = new System.Drawing.Point(283, 180);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(101, 43);
            this.Cancel_btn.TabIndex = 4;
            this.Cancel_btn.Text = "Отмена";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // SaveCloseHospital_btn
            // 
            this.SaveCloseHospital_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveCloseHospital_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveCloseHospital_btn.Location = new System.Drawing.Point(132, 180);
            this.SaveCloseHospital_btn.Name = "SaveCloseHospital_btn";
            this.SaveCloseHospital_btn.Size = new System.Drawing.Size(145, 43);
            this.SaveCloseHospital_btn.TabIndex = 3;
            this.SaveCloseHospital_btn.Text = "Сохранить и закрыть";
            this.SaveCloseHospital_btn.UseVisualStyleBackColor = true;
            this.SaveCloseHospital_btn.Click += new System.EventHandler(this.SaveCloseHospital_btn_Click);
            // 
            // NewHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(416, 268);
            this.Controls.Add(this.SaveCloseHospital_btn);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.SaveHospital_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressClinic_tb);
            this.Controls.Add(this.NameClinic_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные поликлиники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameClinic_tb;
        private System.Windows.Forms.TextBox AddressClinic_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveHospital_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button SaveCloseHospital_btn;
    }
}
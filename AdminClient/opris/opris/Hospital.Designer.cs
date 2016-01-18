namespace opris
{
    partial class Hospital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DelHospital_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressSearch_tb = new System.Windows.Forms.TextBox();
            this.NameSearch_tb = new System.Windows.Forms.TextBox();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Hospital_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Specialization_cb = new System.Windows.Forms.ComboBox();
            this.Hospital_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchSurname_tb = new System.Windows.Forms.TextBox();
            this.DelDoctor_btn = new System.Windows.Forms.Button();
            this.TimeTable_gb = new System.Windows.Forms.GroupBox();
            this.eSun_tb = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eSat_tb = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.eFri_tb = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eThu_tb = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sMon_tb = new System.Windows.Forms.MaskedTextBox();
            this.eMon_tb = new System.Windows.Forms.MaskedTextBox();
            this.eWed_tb = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.eTue_tb = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.sSun_tb = new System.Windows.Forms.MaskedTextBox();
            this.sSat_tb = new System.Windows.Forms.MaskedTextBox();
            this.sTue_tb = new System.Windows.Forms.MaskedTextBox();
            this.sFri_tb = new System.Windows.Forms.MaskedTextBox();
            this.sWed_tb = new System.Windows.Forms.MaskedTextBox();
            this.sThu_tb = new System.Windows.Forms.MaskedTextBox();
            this.CancelDoctor_btn = new System.Windows.Forms.Button();
            this.ChangeDoctor_btn = new System.Windows.Forms.Button();
            this.AddDoctor_btn = new System.Windows.Forms.Button();
            this.Doctor_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.DelSpecialization_btn = new System.Windows.Forms.Button();
            this.ChangeSpecialization_btn = new System.Windows.Forms.Button();
            this.AddSpecialization_btn = new System.Windows.Forms.Button();
            this.Specialization_dataGrid = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_dataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.TimeTable_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_dataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Specialization_dataGrid)).BeginInit();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 495);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.loadSearch);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.DelHospital_btn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Close_btn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddressSearch_tb);
            this.tabPage1.Controls.Add(this.NameSearch_tb);
            this.tabPage1.Controls.Add(this.Change_btn);
            this.tabPage1.Controls.Add(this.Add_btn);
            this.tabPage1.Controls.Add(this.Hospital_dataGrid);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1020, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "1";
            this.tabPage1.Text = "Поликлиники";
            // 
            // DelHospital_btn
            // 
            this.DelHospital_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DelHospital_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelHospital_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelHospital_btn.Location = new System.Drawing.Point(280, 29);
            this.DelHospital_btn.Name = "DelHospital_btn";
            this.DelHospital_btn.Size = new System.Drawing.Size(125, 39);
            this.DelHospital_btn.TabIndex = 10;
            this.DelHospital_btn.Text = "Удалить";
            this.DelHospital_btn.UseVisualStyleBackColor = true;
            this.DelHospital_btn.Click += new System.EventHandler(this.DelHospital_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(731, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование";
            // 
            // Close_btn
            // 
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_btn.Location = new System.Drawing.Point(892, 426);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(125, 39);
            this.Close_btn.TabIndex = 7;
            this.Close_btn.Text = "Отмена";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(479, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск";
            // 
            // AddressSearch_tb
            // 
            this.AddressSearch_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddressSearch_tb.Location = new System.Drawing.Point(717, 33);
            this.AddressSearch_tb.Name = "AddressSearch_tb";
            this.AddressSearch_tb.Size = new System.Drawing.Size(197, 25);
            this.AddressSearch_tb.TabIndex = 4;
            this.AddressSearch_tb.TextChanged += new System.EventHandler(this.Hospital_load);
            // 
            // NameSearch_tb
            // 
            this.NameSearch_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NameSearch_tb.Location = new System.Drawing.Point(529, 33);
            this.NameSearch_tb.Name = "NameSearch_tb";
            this.NameSearch_tb.Size = new System.Drawing.Size(174, 25);
            this.NameSearch_tb.TabIndex = 3;
            this.NameSearch_tb.TextChanged += new System.EventHandler(this.Hospital_load);
            // 
            // Change_btn
            // 
            this.Change_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Change_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_btn.Location = new System.Drawing.Point(149, 29);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(125, 39);
            this.Change_btn.TabIndex = 2;
            this.Change_btn.Text = "Редактировать";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_btn.Location = new System.Drawing.Point(18, 29);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(125, 39);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "Добавить";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Hospital_dataGrid
            // 
            this.Hospital_dataGrid.AccessibleName = "";
            this.Hospital_dataGrid.AllowUserToAddRows = false;
            this.Hospital_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Hospital_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Hospital_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Hospital_dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Hospital_dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Hospital_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Hospital_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hospital_dataGrid.Location = new System.Drawing.Point(-4, 78);
            this.Hospital_dataGrid.MultiSelect = false;
            this.Hospital_dataGrid.Name = "Hospital_dataGrid";
            this.Hospital_dataGrid.ReadOnly = true;
            this.Hospital_dataGrid.RowHeadersVisible = false;
            this.Hospital_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Hospital_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Hospital_dataGrid.RowTemplate.ReadOnly = true;
            this.Hospital_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Hospital_dataGrid.Size = new System.Drawing.Size(1028, 339);
            this.Hospital_dataGrid.TabIndex = 0;
            this.Hospital_dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Change_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Specialization_cb);
            this.tabPage2.Controls.Add(this.Hospital_cb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.SearchSurname_tb);
            this.tabPage2.Controls.Add(this.DelDoctor_btn);
            this.tabPage2.Controls.Add(this.TimeTable_gb);
            this.tabPage2.Controls.Add(this.CancelDoctor_btn);
            this.tabPage2.Controls.Add(this.ChangeDoctor_btn);
            this.tabPage2.Controls.Add(this.AddDoctor_btn);
            this.tabPage2.Controls.Add(this.Doctor_dataGrid);
            this.tabPage2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "2";
            this.tabPage2.Text = "Врачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(841, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 64;
            this.label14.Text = "Специализация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(683, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "Поликлиника";
            // 
            // Specialization_cb
            // 
            this.Specialization_cb.FormattingEnabled = true;
            this.Specialization_cb.Location = new System.Drawing.Point(832, 35);
            this.Specialization_cb.Name = "Specialization_cb";
            this.Specialization_cb.Size = new System.Drawing.Size(143, 26);
            this.Specialization_cb.TabIndex = 62;
            this.Specialization_cb.TextChanged += new System.EventHandler(this.Hospital_load);
            // 
            // Hospital_cb
            // 
            this.Hospital_cb.FormattingEnabled = true;
            this.Hospital_cb.Location = new System.Drawing.Point(674, 35);
            this.Hospital_cb.Name = "Hospital_cb";
            this.Hospital_cb.Size = new System.Drawing.Size(152, 26);
            this.Hospital_cb.TabIndex = 61;
            this.Hospital_cb.TextChanged += new System.EventHandler(this.Hospital_load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(502, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(444, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Поиск";
            // 
            // SearchSurname_tb
            // 
            this.SearchSurname_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchSurname_tb.Location = new System.Drawing.Point(494, 36);
            this.SearchSurname_tb.Name = "SearchSurname_tb";
            this.SearchSurname_tb.Size = new System.Drawing.Size(174, 25);
            this.SearchSurname_tb.TabIndex = 58;
            this.SearchSurname_tb.TextChanged += new System.EventHandler(this.Hospital_load);
            // 
            // DelDoctor_btn
            // 
            this.DelDoctor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelDoctor_btn.Location = new System.Drawing.Point(280, 29);
            this.DelDoctor_btn.Name = "DelDoctor_btn";
            this.DelDoctor_btn.Size = new System.Drawing.Size(125, 39);
            this.DelDoctor_btn.TabIndex = 57;
            this.DelDoctor_btn.Text = "Удалить";
            this.DelDoctor_btn.UseVisualStyleBackColor = true;
            this.DelDoctor_btn.Click += new System.EventHandler(this.DelDoctor_btn_Click);
            // 
            // TimeTable_gb
            // 
            this.TimeTable_gb.AutoSize = true;
            this.TimeTable_gb.Controls.Add(this.eSun_tb);
            this.TimeTable_gb.Controls.Add(this.label7);
            this.TimeTable_gb.Controls.Add(this.eSat_tb);
            this.TimeTable_gb.Controls.Add(this.label8);
            this.TimeTable_gb.Controls.Add(this.eFri_tb);
            this.TimeTable_gb.Controls.Add(this.label9);
            this.TimeTable_gb.Controls.Add(this.eThu_tb);
            this.TimeTable_gb.Controls.Add(this.label10);
            this.TimeTable_gb.Controls.Add(this.sMon_tb);
            this.TimeTable_gb.Controls.Add(this.eMon_tb);
            this.TimeTable_gb.Controls.Add(this.eWed_tb);
            this.TimeTable_gb.Controls.Add(this.label11);
            this.TimeTable_gb.Controls.Add(this.eTue_tb);
            this.TimeTable_gb.Controls.Add(this.label12);
            this.TimeTable_gb.Controls.Add(this.label13);
            this.TimeTable_gb.Controls.Add(this.sSun_tb);
            this.TimeTable_gb.Controls.Add(this.sSat_tb);
            this.TimeTable_gb.Controls.Add(this.sTue_tb);
            this.TimeTable_gb.Controls.Add(this.sFri_tb);
            this.TimeTable_gb.Controls.Add(this.sWed_tb);
            this.TimeTable_gb.Controls.Add(this.sThu_tb);
            this.TimeTable_gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimeTable_gb.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTable_gb.Location = new System.Drawing.Point(808, 72);
            this.TimeTable_gb.Name = "TimeTable_gb";
            this.TimeTable_gb.Size = new System.Drawing.Size(193, 337);
            this.TimeTable_gb.TabIndex = 56;
            this.TimeTable_gb.TabStop = false;
            this.TimeTable_gb.Text = "Расписание";
            // 
            // eSun_tb
            // 
            this.eSun_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eSun_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eSun_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eSun_tb.Location = new System.Drawing.Point(106, 272);
            this.eSun_tb.Mask = "00:00";
            this.eSun_tb.Name = "eSun_tb";
            this.eSun_tb.PromptChar = ' ';
            this.eSun_tb.ReadOnly = true;
            this.eSun_tb.Size = new System.Drawing.Size(43, 21);
            this.eSun_tb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Пн";
            // 
            // eSat_tb
            // 
            this.eSat_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eSat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eSat_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eSat_tb.Location = new System.Drawing.Point(106, 232);
            this.eSat_tb.Mask = "00:00";
            this.eSat_tb.Name = "eSat_tb";
            this.eSat_tb.PromptChar = ' ';
            this.eSat_tb.ReadOnly = true;
            this.eSat_tb.Size = new System.Drawing.Size(43, 21);
            this.eSat_tb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(21, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Вт";
            // 
            // eFri_tb
            // 
            this.eFri_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eFri_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eFri_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eFri_tb.Location = new System.Drawing.Point(106, 191);
            this.eFri_tb.Mask = "00:00";
            this.eFri_tb.Name = "eFri_tb";
            this.eFri_tb.PromptChar = ' ';
            this.eFri_tb.ReadOnly = true;
            this.eFri_tb.Size = new System.Drawing.Size(43, 21);
            this.eFri_tb.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ср";
            // 
            // eThu_tb
            // 
            this.eThu_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eThu_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eThu_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eThu_tb.Location = new System.Drawing.Point(106, 152);
            this.eThu_tb.Mask = "00:00";
            this.eThu_tb.Name = "eThu_tb";
            this.eThu_tb.PromptChar = ' ';
            this.eThu_tb.ReadOnly = true;
            this.eThu_tb.Size = new System.Drawing.Size(43, 21);
            this.eThu_tb.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(21, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Чт";
            // 
            // sMon_tb
            // 
            this.sMon_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sMon_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sMon_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sMon_tb.Location = new System.Drawing.Point(58, 31);
            this.sMon_tb.Mask = "00:00";
            this.sMon_tb.Name = "sMon_tb";
            this.sMon_tb.PromptChar = ' ';
            this.sMon_tb.ReadOnly = true;
            this.sMon_tb.Size = new System.Drawing.Size(42, 21);
            this.sMon_tb.TabIndex = 5;
            this.sMon_tb.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.sMon_tb.ValidatingType = typeof(System.DateTime);
            // 
            // eMon_tb
            // 
            this.eMon_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eMon_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eMon_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMon_tb.Location = new System.Drawing.Point(107, 31);
            this.eMon_tb.Mask = "00:00";
            this.eMon_tb.Name = "eMon_tb";
            this.eMon_tb.PromptChar = ' ';
            this.eMon_tb.ReadOnly = true;
            this.eMon_tb.Size = new System.Drawing.Size(42, 21);
            this.eMon_tb.TabIndex = 6;
            this.eMon_tb.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.eMon_tb.ValidatingType = typeof(System.DateTime);
            // 
            // eWed_tb
            // 
            this.eWed_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eWed_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eWed_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eWed_tb.Location = new System.Drawing.Point(107, 112);
            this.eWed_tb.Mask = "00:00";
            this.eWed_tb.Name = "eWed_tb";
            this.eWed_tb.PromptChar = ' ';
            this.eWed_tb.ReadOnly = true;
            this.eWed_tb.Size = new System.Drawing.Size(42, 21);
            this.eWed_tb.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(21, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Пт";
            // 
            // eTue_tb
            // 
            this.eTue_tb.BackColor = System.Drawing.SystemColors.Window;
            this.eTue_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eTue_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eTue_tb.Location = new System.Drawing.Point(107, 72);
            this.eTue_tb.Mask = "00:00";
            this.eTue_tb.Name = "eTue_tb";
            this.eTue_tb.PromptChar = ' ';
            this.eTue_tb.ReadOnly = true;
            this.eTue_tb.Size = new System.Drawing.Size(42, 21);
            this.eTue_tb.TabIndex = 8;
            this.eTue_tb.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Сб";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(21, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Вс";
            // 
            // sSun_tb
            // 
            this.sSun_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sSun_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sSun_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sSun_tb.Location = new System.Drawing.Point(59, 272);
            this.sSun_tb.Mask = "00:00";
            this.sSun_tb.Name = "sSun_tb";
            this.sSun_tb.PromptChar = ' ';
            this.sSun_tb.ReadOnly = true;
            this.sSun_tb.Size = new System.Drawing.Size(41, 21);
            this.sSun_tb.TabIndex = 17;
            this.sSun_tb.ValidatingType = typeof(System.DateTime);
            // 
            // sSat_tb
            // 
            this.sSat_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sSat_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sSat_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sSat_tb.Location = new System.Drawing.Point(59, 232);
            this.sSat_tb.Mask = "00:00";
            this.sSat_tb.Name = "sSat_tb";
            this.sSat_tb.PromptChar = ' ';
            this.sSat_tb.ReadOnly = true;
            this.sSat_tb.Size = new System.Drawing.Size(41, 21);
            this.sSat_tb.TabIndex = 15;
            this.sSat_tb.ValidatingType = typeof(System.DateTime);
            // 
            // sTue_tb
            // 
            this.sTue_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sTue_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sTue_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sTue_tb.Location = new System.Drawing.Point(59, 72);
            this.sTue_tb.Mask = "00:00";
            this.sTue_tb.Name = "sTue_tb";
            this.sTue_tb.PromptChar = ' ';
            this.sTue_tb.ReadOnly = true;
            this.sTue_tb.Size = new System.Drawing.Size(41, 21);
            this.sTue_tb.TabIndex = 7;
            this.sTue_tb.ValidatingType = typeof(System.DateTime);
            // 
            // sFri_tb
            // 
            this.sFri_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sFri_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sFri_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sFri_tb.Location = new System.Drawing.Point(59, 191);
            this.sFri_tb.Mask = "00:00";
            this.sFri_tb.Name = "sFri_tb";
            this.sFri_tb.PromptChar = ' ';
            this.sFri_tb.ReadOnly = true;
            this.sFri_tb.Size = new System.Drawing.Size(41, 21);
            this.sFri_tb.TabIndex = 13;
            this.sFri_tb.ValidatingType = typeof(System.DateTime);
            // 
            // sWed_tb
            // 
            this.sWed_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sWed_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sWed_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sWed_tb.Location = new System.Drawing.Point(59, 112);
            this.sWed_tb.Mask = "00:00";
            this.sWed_tb.Name = "sWed_tb";
            this.sWed_tb.PromptChar = ' ';
            this.sWed_tb.ReadOnly = true;
            this.sWed_tb.Size = new System.Drawing.Size(41, 21);
            this.sWed_tb.TabIndex = 9;
            this.sWed_tb.ValidatingType = typeof(System.DateTime);
            // 
            // sThu_tb
            // 
            this.sThu_tb.BackColor = System.Drawing.SystemColors.Window;
            this.sThu_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sThu_tb.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sThu_tb.Location = new System.Drawing.Point(59, 152);
            this.sThu_tb.Mask = "00:00";
            this.sThu_tb.Name = "sThu_tb";
            this.sThu_tb.PromptChar = ' ';
            this.sThu_tb.ReadOnly = true;
            this.sThu_tb.Size = new System.Drawing.Size(41, 21);
            this.sThu_tb.TabIndex = 11;
            this.sThu_tb.ValidatingType = typeof(System.DateTime);
            // 
            // CancelDoctor_btn
            // 
            this.CancelDoctor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelDoctor_btn.Location = new System.Drawing.Point(876, 428);
            this.CancelDoctor_btn.Name = "CancelDoctor_btn";
            this.CancelDoctor_btn.Size = new System.Drawing.Size(125, 39);
            this.CancelDoctor_btn.TabIndex = 6;
            this.CancelDoctor_btn.Text = "Отмена";
            this.CancelDoctor_btn.UseVisualStyleBackColor = true;
            this.CancelDoctor_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // ChangeDoctor_btn
            // 
            this.ChangeDoctor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeDoctor_btn.Location = new System.Drawing.Point(149, 29);
            this.ChangeDoctor_btn.Name = "ChangeDoctor_btn";
            this.ChangeDoctor_btn.Size = new System.Drawing.Size(125, 39);
            this.ChangeDoctor_btn.TabIndex = 3;
            this.ChangeDoctor_btn.Text = "Редактировать";
            this.ChangeDoctor_btn.UseVisualStyleBackColor = true;
            this.ChangeDoctor_btn.Click += new System.EventHandler(this.ChangeDoctor_btn_Click);
            // 
            // AddDoctor_btn
            // 
            this.AddDoctor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDoctor_btn.Location = new System.Drawing.Point(18, 29);
            this.AddDoctor_btn.Name = "AddDoctor_btn";
            this.AddDoctor_btn.Size = new System.Drawing.Size(125, 39);
            this.AddDoctor_btn.TabIndex = 2;
            this.AddDoctor_btn.Text = "Добавить";
            this.AddDoctor_btn.UseVisualStyleBackColor = true;
            this.AddDoctor_btn.Click += new System.EventHandler(this.AddDoctor_btn_Click);
            // 
            // Doctor_dataGrid
            // 
            this.Doctor_dataGrid.AllowUserToAddRows = false;
            this.Doctor_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Doctor_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Doctor_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Doctor_dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Doctor_dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Doctor_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Doctor_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Doctor_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Doctor_dataGrid.Location = new System.Drawing.Point(-4, 83);
            this.Doctor_dataGrid.MultiSelect = false;
            this.Doctor_dataGrid.Name = "Doctor_dataGrid";
            this.Doctor_dataGrid.ReadOnly = true;
            this.Doctor_dataGrid.RowHeadersVisible = false;
            this.Doctor_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Doctor_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Doctor_dataGrid.ShowEditingIcon = false;
            this.Doctor_dataGrid.Size = new System.Drawing.Size(806, 326);
            this.Doctor_dataGrid.TabIndex = 0;
            this.Doctor_dataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeTable);
            this.Doctor_dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChangeDoctor_btn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Cancel_btn);
            this.tabPage3.Controls.Add(this.DelSpecialization_btn);
            this.tabPage3.Controls.Add(this.ChangeSpecialization_btn);
            this.tabPage3.Controls.Add(this.AddSpecialization_btn);
            this.tabPage3.Controls.Add(this.Specialization_dataGrid);
            this.tabPage3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1020, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Специализация";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cancel_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_btn.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_btn.Location = new System.Drawing.Point(876, 428);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(125, 39);
            this.Cancel_btn.TabIndex = 12;
            this.Cancel_btn.Text = "Отмена";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // DelSpecialization_btn
            // 
            this.DelSpecialization_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelSpecialization_btn.Location = new System.Drawing.Point(345, 93);
            this.DelSpecialization_btn.Name = "DelSpecialization_btn";
            this.DelSpecialization_btn.Size = new System.Drawing.Size(125, 39);
            this.DelSpecialization_btn.TabIndex = 11;
            this.DelSpecialization_btn.Text = "Удалить";
            this.DelSpecialization_btn.UseVisualStyleBackColor = true;
            this.DelSpecialization_btn.Click += new System.EventHandler(this.DelSpecialization_btn_Click);
            // 
            // ChangeSpecialization_btn
            // 
            this.ChangeSpecialization_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeSpecialization_btn.Location = new System.Drawing.Point(345, 48);
            this.ChangeSpecialization_btn.Name = "ChangeSpecialization_btn";
            this.ChangeSpecialization_btn.Size = new System.Drawing.Size(125, 39);
            this.ChangeSpecialization_btn.TabIndex = 10;
            this.ChangeSpecialization_btn.Text = "Редактировать";
            this.ChangeSpecialization_btn.UseVisualStyleBackColor = true;
            this.ChangeSpecialization_btn.Click += new System.EventHandler(this.ChangeSpecialization_btn_Click);
            // 
            // AddSpecialization_btn
            // 
            this.AddSpecialization_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSpecialization_btn.Location = new System.Drawing.Point(345, 3);
            this.AddSpecialization_btn.Name = "AddSpecialization_btn";
            this.AddSpecialization_btn.Size = new System.Drawing.Size(125, 39);
            this.AddSpecialization_btn.TabIndex = 9;
            this.AddSpecialization_btn.Text = "Добавить";
            this.AddSpecialization_btn.UseVisualStyleBackColor = true;
            this.AddSpecialization_btn.Click += new System.EventHandler(this.AddSpecialization_btn_Click);
            // 
            // Specialization_dataGrid
            // 
            this.Specialization_dataGrid.AllowUserToAddRows = false;
            this.Specialization_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Specialization_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Specialization_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Specialization_dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Specialization_dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Specialization_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.Specialization_dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Specialization_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Specialization_dataGrid.Location = new System.Drawing.Point(0, 0);
            this.Specialization_dataGrid.MultiSelect = false;
            this.Specialization_dataGrid.Name = "Specialization_dataGrid";
            this.Specialization_dataGrid.ReadOnly = true;
            this.Specialization_dataGrid.RowHeadersVisible = false;
            this.Specialization_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Specialization_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Specialization_dataGrid.ShowEditingIcon = false;
            this.Specialization_dataGrid.Size = new System.Drawing.Size(339, 421);
            this.Specialization_dataGrid.TabIndex = 8;
            this.Specialization_dataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChangeSpecialization_btn_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.StatusLbl});
            this.status.Location = new System.Drawing.Point(0, 492);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1018, 22);
            this.status.TabIndex = 67;
            this.status.Text = "status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLbl
            // 
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(39, 17);
            this.StatusLbl.Text = "Status";
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 514);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Hospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поликлиника";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hospital_dataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TimeTable_gb.ResumeLayout(false);
            this.TimeTable_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor_dataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Specialization_dataGrid)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox AddressSearch_tb;
        private System.Windows.Forms.TextBox NameSearch_tb;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView Hospital_dataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeDoctor_btn;
        private System.Windows.Forms.Button AddDoctor_btn;
        private System.Windows.Forms.Button CancelDoctor_btn;
        private System.Windows.Forms.MaskedTextBox eSun_tb;
        private System.Windows.Forms.MaskedTextBox eSat_tb;
        private System.Windows.Forms.MaskedTextBox eFri_tb;
        private System.Windows.Forms.MaskedTextBox eThu_tb;
        private System.Windows.Forms.MaskedTextBox eWed_tb;
        private System.Windows.Forms.MaskedTextBox eTue_tb;
        private System.Windows.Forms.MaskedTextBox eMon_tb;
        private System.Windows.Forms.MaskedTextBox sSun_tb;
        private System.Windows.Forms.MaskedTextBox sSat_tb;
        private System.Windows.Forms.MaskedTextBox sFri_tb;
        private System.Windows.Forms.MaskedTextBox sThu_tb;
        private System.Windows.Forms.MaskedTextBox sWed_tb;
        private System.Windows.Forms.MaskedTextBox sTue_tb;
        private System.Windows.Forms.MaskedTextBox sMon_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ChangeSpecialization_btn;
        private System.Windows.Forms.Button AddSpecialization_btn;
        private System.Windows.Forms.DataGridView Specialization_dataGrid;
        private System.Windows.Forms.GroupBox TimeTable_gb;
        private System.Windows.Forms.Button DelHospital_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Specialization_cb;
        private System.Windows.Forms.ComboBox Hospital_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchSurname_tb;
        private System.Windows.Forms.Button DelDoctor_btn;
        private System.Windows.Forms.Button DelSpecialization_btn;
        private System.Windows.Forms.Button Cancel_btn;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.StatusStrip status;
        public System.Windows.Forms.DataGridView Doctor_dataGrid;
        public System.Windows.Forms.ToolStripStatusLabel StatusLbl;
    }
}
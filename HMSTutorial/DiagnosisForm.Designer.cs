namespace HMSTutorial
{
    partial class DiagnosisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PatientIdCb = new System.Windows.Forms.ComboBox();
            this.PatientTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SymptomsTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DiagnosisTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MedicineTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.diagsummary = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Diagnosislbl = new System.Windows.Forms.Label();
            this.medicineslbl = new System.Windows.Forms.Label();
            this.Symptomslbl = new System.Windows.Forms.Label();
            this.PatientNamelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 92);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Selena", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(877, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Selena", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Selena", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DiagId
            // 
            this.DiagId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagId.HintForeColor = System.Drawing.Color.Empty;
            this.DiagId.HintText = "";
            this.DiagId.isPassword = false;
            this.DiagId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineIdleColor = System.Drawing.Color.Gray;
            this.DiagId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagId.LineThickness = 3;
            this.DiagId.Location = new System.Drawing.Point(27, 115);
            this.DiagId.Margin = new System.Windows.Forms.Padding(4);
            this.DiagId.Name = "DiagId";
            this.DiagId.Size = new System.Drawing.Size(147, 30);
            this.DiagId.TabIndex = 3;
            this.DiagId.Text = "DiagnosisId";
            this.DiagId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PatientIdCb
            // 
            this.PatientIdCb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientIdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientIdCb.FormattingEnabled = true;
            this.PatientIdCb.Location = new System.Drawing.Point(27, 159);
            this.PatientIdCb.Name = "PatientIdCb";
            this.PatientIdCb.Size = new System.Drawing.Size(147, 25);
            this.PatientIdCb.TabIndex = 8;
            this.PatientIdCb.Text = "PatientId";
            this.PatientIdCb.SelectionChangeCommitted += new System.EventHandler(this.PatientIdCb_SelectionChangeCommitted);
            // 
            // PatientTb
            // 
            this.PatientTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientTb.Enabled = false;
            this.PatientTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PatientTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PatientTb.HintForeColor = System.Drawing.Color.Empty;
            this.PatientTb.HintText = "";
            this.PatientTb.isPassword = false;
            this.PatientTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.PatientTb.LineIdleColor = System.Drawing.Color.Gray;
            this.PatientTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.PatientTb.LineThickness = 3;
            this.PatientTb.Location = new System.Drawing.Point(27, 190);
            this.PatientTb.Margin = new System.Windows.Forms.Padding(4);
            this.PatientTb.Name = "PatientTb";
            this.PatientTb.Size = new System.Drawing.Size(147, 30);
            this.PatientTb.TabIndex = 9;
            this.PatientTb.Text = "PatientName";
            this.PatientTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SymptomsTb
            // 
            this.SymptomsTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SymptomsTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SymptomsTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SymptomsTb.HintForeColor = System.Drawing.Color.Empty;
            this.SymptomsTb.HintText = "";
            this.SymptomsTb.isPassword = false;
            this.SymptomsTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.SymptomsTb.LineIdleColor = System.Drawing.Color.Gray;
            this.SymptomsTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.SymptomsTb.LineThickness = 3;
            this.SymptomsTb.Location = new System.Drawing.Point(201, 115);
            this.SymptomsTb.Margin = new System.Windows.Forms.Padding(4);
            this.SymptomsTb.Name = "SymptomsTb";
            this.SymptomsTb.Size = new System.Drawing.Size(147, 30);
            this.SymptomsTb.TabIndex = 10;
            this.SymptomsTb.Text = "Symptoms";
            this.SymptomsTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DiagnosisTb
            // 
            this.DiagnosisTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiagnosisTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DiagnosisTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DiagnosisTb.HintForeColor = System.Drawing.Color.Empty;
            this.DiagnosisTb.HintText = "";
            this.DiagnosisTb.isPassword = false;
            this.DiagnosisTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineIdleColor = System.Drawing.Color.Gray;
            this.DiagnosisTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DiagnosisTb.LineThickness = 3;
            this.DiagnosisTb.Location = new System.Drawing.Point(201, 153);
            this.DiagnosisTb.Margin = new System.Windows.Forms.Padding(4);
            this.DiagnosisTb.Name = "DiagnosisTb";
            this.DiagnosisTb.Size = new System.Drawing.Size(147, 30);
            this.DiagnosisTb.TabIndex = 11;
            this.DiagnosisTb.Text = "Diagnosis";
            this.DiagnosisTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MedicineTb
            // 
            this.MedicineTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicineTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MedicineTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineTb.HintForeColor = System.Drawing.Color.Empty;
            this.MedicineTb.HintText = "";
            this.MedicineTb.isPassword = false;
            this.MedicineTb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineIdleColor = System.Drawing.Color.Gray;
            this.MedicineTb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.MedicineTb.LineThickness = 3;
            this.MedicineTb.Location = new System.Drawing.Point(201, 191);
            this.MedicineTb.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineTb.Name = "MedicineTb";
            this.MedicineTb.Size = new System.Drawing.Size(147, 30);
            this.MedicineTb.TabIndex = 12;
            this.MedicineTb.Text = "Medicines";
            this.MedicineTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(121, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 44);
            this.button4.TabIndex = 18;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(220, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(117, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(18, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Selena", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(347, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "DIAGNOSIS LIST";
            // 
            // diagsummary
            // 
            this.diagsummary.Controls.Add(this.label11);
            this.diagsummary.Controls.Add(this.label10);
            this.diagsummary.Controls.Add(this.Diagnosislbl);
            this.diagsummary.Controls.Add(this.medicineslbl);
            this.diagsummary.Controls.Add(this.Symptomslbl);
            this.diagsummary.Controls.Add(this.PatientNamelbl);
            this.diagsummary.Controls.Add(this.label4);
            this.diagsummary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diagsummary.Location = new System.Drawing.Point(391, 98);
            this.diagsummary.Name = "diagsummary";
            this.diagsummary.Size = new System.Drawing.Size(511, 323);
            this.diagsummary.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(200, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "ByCodeSpace";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(154, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "HospitalManagementSystem";
            // 
            // Diagnosislbl
            // 
            this.Diagnosislbl.AutoSize = true;
            this.Diagnosislbl.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Diagnosislbl.ForeColor = System.Drawing.Color.Black;
            this.Diagnosislbl.Location = new System.Drawing.Point(280, 103);
            this.Diagnosislbl.Name = "Diagnosislbl";
            this.Diagnosislbl.Size = new System.Drawing.Size(73, 20);
            this.Diagnosislbl.TabIndex = 7;
            this.Diagnosislbl.Text = "Diagnosis";
            // 
            // medicineslbl
            // 
            this.medicineslbl.AutoSize = true;
            this.medicineslbl.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicineslbl.ForeColor = System.Drawing.Color.Black;
            this.medicineslbl.Location = new System.Drawing.Point(280, 177);
            this.medicineslbl.Name = "medicineslbl";
            this.medicineslbl.Size = new System.Drawing.Size(77, 20);
            this.medicineslbl.TabIndex = 6;
            this.medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            this.Symptomslbl.AutoSize = true;
            this.Symptomslbl.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Symptomslbl.ForeColor = System.Drawing.Color.Black;
            this.Symptomslbl.Location = new System.Drawing.Point(81, 177);
            this.Symptomslbl.Name = "Symptomslbl";
            this.Symptomslbl.Size = new System.Drawing.Size(82, 20);
            this.Symptomslbl.TabIndex = 5;
            this.Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            this.PatientNamelbl.AutoSize = true;
            this.PatientNamelbl.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientNamelbl.ForeColor = System.Drawing.Color.Black;
            this.PatientNamelbl.Location = new System.Drawing.Point(81, 103);
            this.PatientNamelbl.Name = "PatientNamelbl";
            this.PatientNamelbl.Size = new System.Drawing.Size(96, 20);
            this.PatientNamelbl.TabIndex = 4;
            this.PatientNamelbl.Text = "PatientName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Selena", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(152, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DiagnosisGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DiagnosisGV.BackgroundColor = System.Drawing.Color.White;
            this.DiagnosisGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DiagnosisGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiagnosisGV.EnableHeadersVisualStyles = false;
            this.DiagnosisGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.Location = new System.Drawing.Point(27, 457);
            this.DiagnosisGV.Name = "DiagnosisGV";
            this.DiagnosisGV.RowHeadersVisible = false;
            this.DiagnosisGV.RowTemplate.Height = 30;
            this.DiagnosisGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DiagnosisGV.Size = new System.Drawing.Size(875, 240);
            this.DiagnosisGV.TabIndex = 22;
            this.DiagnosisGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiagnosisGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DiagnosisGV.ThemeStyle.ReadOnly = false;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.Height = 30;
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Selena", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(617, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 27);
            this.button5.TabIndex = 23;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 10);
            this.panel2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Selena", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(348, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DiagnosisGV);
            this.Controls.Add(this.diagsummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicineTb);
            this.Controls.Add(this.DiagnosisTb);
            this.Controls.Add(this.SymptomsTb);
            this.Controls.Add(this.PatientTb);
            this.Controls.Add(this.PatientIdCb);
            this.Controls.Add(this.DiagId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.diagsummary.ResumeLayout(false);
            this.diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagId;
        private System.Windows.Forms.ComboBox PatientIdCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PatientTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SymptomsTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DiagnosisTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedicineTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel diagsummary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Diagnosislbl;
        private System.Windows.Forms.Label medicineslbl;
        private System.Windows.Forms.Label Symptomslbl;
        private System.Windows.Forms.Label PatientNamelbl;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisGV;
        private System.Windows.Forms.Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}
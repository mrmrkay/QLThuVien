namespace QLThuVien.UserControlls
{
    partial class ucBorrow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMuonTra = new System.Windows.Forms.TabControl();
            this.tpCTPM = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPMSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPMDocGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.btnPMXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPMSua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPMNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btnPMThem = new System.Windows.Forms.Button();
            this.dtpPMNgayTra = new System.Windows.Forms.DateTimePicker();
            this.tpCTPT = new System.Windows.Forms.TabPage();
            this.btnPTXoa = new System.Windows.Forms.Button();
            this.btnPTSua = new System.Windows.Forms.Button();
            this.btnPTThem = new System.Windows.Forms.Button();
            this.dtpPTNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtPTMaPhieu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_cbbPTHH = new System.Windows.Forms.ComboBox();
            this.m_txtPTTienPhat = new System.Windows.Forms.TextBox();
            this.m_txtPTsoNgayTre = new System.Windows.Forms.TextBox();
            this.m_rtbPTLyDo = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvPhieuTra = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cmbPTDocGia = new System.Windows.Forms.ComboBox();
            this.cmbPTSach = new System.Windows.Forms.ComboBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.tcMuonTra.SuspendLayout();
            this.tpCTPM.SuspendLayout();
            this.tpCTPT.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMuonTra
            // 
            this.tcMuonTra.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMuonTra.Controls.Add(this.tpCTPM);
            this.tcMuonTra.Controls.Add(this.tpCTPT);
            this.tcMuonTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMuonTra.Location = new System.Drawing.Point(0, 0);
            this.tcMuonTra.Margin = new System.Windows.Forms.Padding(2);
            this.tcMuonTra.Name = "tcMuonTra";
            this.tcMuonTra.SelectedIndex = 0;
            this.tcMuonTra.Size = new System.Drawing.Size(969, 535);
            this.tcMuonTra.TabIndex = 1;
            // 
            // tpCTPM
            // 
            this.tpCTPM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tpCTPM.Controls.Add(this.dgvPhieuMuon);
            this.tpCTPM.Controls.Add(this.label1);
            this.tpCTPM.Controls.Add(this.cmbPMSach);
            this.tpCTPM.Controls.Add(this.label2);
            this.tpCTPM.Controls.Add(this.cmbPMDocGia);
            this.tpCTPM.Controls.Add(this.dtpPMNgayTra);
            this.tpCTPM.Controls.Add(this.label3);
            this.tpCTPM.Controls.Add(this.btnPMThem);
            this.tpCTPM.Controls.Add(this.txtMaPhieuMuon);
            this.tpCTPM.Controls.Add(this.dtpPMNgayMuon);
            this.tpCTPM.Controls.Add(this.btnPMXoa);
            this.tpCTPM.Controls.Add(this.label8);
            this.tpCTPM.Controls.Add(this.label7);
            this.tpCTPM.Controls.Add(this.btnPMSua);
            this.tpCTPM.Location = new System.Drawing.Point(4, 25);
            this.tpCTPM.Margin = new System.Windows.Forms.Padding(2);
            this.tpCTPM.Name = "tpCTPM";
            this.tpCTPM.Size = new System.Drawing.Size(961, 506);
            this.tpCTPM.TabIndex = 2;
            this.tpCTPM.Text = "Chi tiết Phiếu Mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // cmbPMSach
            // 
            this.cmbPMSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMSach.FormattingEnabled = true;
            this.cmbPMSach.Location = new System.Drawing.Point(371, 16);
            this.cmbPMSach.Name = "cmbPMSach";
            this.cmbPMSach.Size = new System.Drawing.Size(131, 21);
            this.cmbPMSach.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đọc giả:";
            // 
            // cmbPMDocGia
            // 
            this.cmbPMDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPMDocGia.FormattingEnabled = true;
            this.cmbPMDocGia.Location = new System.Drawing.Point(129, 60);
            this.cmbPMDocGia.Name = "cmbPMDocGia";
            this.cmbPMDocGia.Size = new System.Drawing.Size(131, 21);
            this.cmbPMDocGia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(129, 21);
            this.txtMaPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuMuon.Multiline = true;
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(131, 25);
            this.txtMaPhieuMuon.TabIndex = 3;
            // 
            // btnPMXoa
            // 
            this.btnPMXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPMXoa.FlatAppearance.BorderSize = 0;
            this.btnPMXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMXoa.ForeColor = System.Drawing.Color.White;
            this.btnPMXoa.Location = new System.Drawing.Point(344, 104);
            this.btnPMXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPMXoa.Name = "btnPMXoa";
            this.btnPMXoa.Size = new System.Drawing.Size(112, 42);
            this.btnPMXoa.TabIndex = 9;
            this.btnPMXoa.Text = "Xóa";
            this.btnPMXoa.UseVisualStyleBackColor = false;
            this.btnPMXoa.Click += new System.EventHandler(this.btnPMXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày Mượn:";
            // 
            // btnPMSua
            // 
            this.btnPMSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPMSua.FlatAppearance.BorderSize = 0;
            this.btnPMSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMSua.ForeColor = System.Drawing.Color.White;
            this.btnPMSua.Location = new System.Drawing.Point(197, 104);
            this.btnPMSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnPMSua.Name = "btnPMSua";
            this.btnPMSua.Size = new System.Drawing.Size(112, 42);
            this.btnPMSua.TabIndex = 8;
            this.btnPMSua.Text = "Sửa";
            this.btnPMSua.UseVisualStyleBackColor = false;
            this.btnPMSua.Click += new System.EventHandler(this.btnPMSua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày Trả:";
            // 
            // dtpPMNgayMuon
            // 
            this.dtpPMNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPMNgayMuon.Location = new System.Drawing.Point(371, 60);
            this.dtpPMNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPMNgayMuon.Name = "dtpPMNgayMuon";
            this.dtpPMNgayMuon.Size = new System.Drawing.Size(131, 20);
            this.dtpPMNgayMuon.TabIndex = 2;
            // 
            // btnPMThem
            // 
            this.btnPMThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPMThem.FlatAppearance.BorderSize = 0;
            this.btnPMThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPMThem.ForeColor = System.Drawing.Color.White;
            this.btnPMThem.Location = new System.Drawing.Point(47, 104);
            this.btnPMThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnPMThem.Name = "btnPMThem";
            this.btnPMThem.Size = new System.Drawing.Size(110, 42);
            this.btnPMThem.TabIndex = 6;
            this.btnPMThem.Text = "Thêm";
            this.btnPMThem.UseVisualStyleBackColor = false;
            this.btnPMThem.Click += new System.EventHandler(this.btnPMThem_Click);
            // 
            // dtpPMNgayTra
            // 
            this.dtpPMNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPMNgayTra.Location = new System.Drawing.Point(613, 23);
            this.dtpPMNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPMNgayTra.Name = "dtpPMNgayTra";
            this.dtpPMNgayTra.Size = new System.Drawing.Size(131, 20);
            this.dtpPMNgayTra.TabIndex = 2;
            this.dtpPMNgayTra.Value = new System.DateTime(2019, 4, 9, 23, 51, 44, 0);
            // 
            // tpCTPT
            // 
            this.tpCTPT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tpCTPT.Controls.Add(this.cmbPTSach);
            this.tpCTPT.Controls.Add(this.cmbPTDocGia);
            this.tpCTPT.Controls.Add(this.btnPTXoa);
            this.tpCTPT.Controls.Add(this.btnPTSua);
            this.tpCTPT.Controls.Add(this.btnPTThem);
            this.tpCTPT.Controls.Add(this.dtpPTNgayTra);
            this.tpCTPT.Controls.Add(this.txtPTMaPhieu);
            this.tpCTPT.Controls.Add(this.groupBox3);
            this.tpCTPT.Controls.Add(this.label29);
            this.tpCTPT.Controls.Add(this.dgvPhieuTra);
            this.tpCTPT.Controls.Add(this.label18);
            this.tpCTPT.Controls.Add(this.label17);
            this.tpCTPT.Controls.Add(this.label13);
            this.tpCTPT.Location = new System.Drawing.Point(4, 25);
            this.tpCTPT.Margin = new System.Windows.Forms.Padding(2);
            this.tpCTPT.Name = "tpCTPT";
            this.tpCTPT.Size = new System.Drawing.Size(961, 506);
            this.tpCTPT.TabIndex = 3;
            this.tpCTPT.Text = "Chi tiết Phiếu Trả";
            // 
            // btnPTXoa
            // 
            this.btnPTXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPTXoa.FlatAppearance.BorderSize = 0;
            this.btnPTXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTXoa.ForeColor = System.Drawing.Color.White;
            this.btnPTXoa.Location = new System.Drawing.Point(276, 165);
            this.btnPTXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPTXoa.Name = "btnPTXoa";
            this.btnPTXoa.Size = new System.Drawing.Size(82, 38);
            this.btnPTXoa.TabIndex = 8;
            this.btnPTXoa.Text = "Xóa";
            this.btnPTXoa.UseVisualStyleBackColor = false;
            this.btnPTXoa.Click += new System.EventHandler(this.btnPTXoa_Click);
            // 
            // btnPTSua
            // 
            this.btnPTSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPTSua.FlatAppearance.BorderSize = 0;
            this.btnPTSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTSua.ForeColor = System.Drawing.Color.White;
            this.btnPTSua.Location = new System.Drawing.Point(151, 165);
            this.btnPTSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnPTSua.Name = "btnPTSua";
            this.btnPTSua.Size = new System.Drawing.Size(82, 38);
            this.btnPTSua.TabIndex = 7;
            this.btnPTSua.Text = "Sửa";
            this.btnPTSua.UseVisualStyleBackColor = false;
            this.btnPTSua.Click += new System.EventHandler(this.btnPTSua_Click);
            // 
            // btnPTThem
            // 
            this.btnPTThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(110)))));
            this.btnPTThem.FlatAppearance.BorderSize = 0;
            this.btnPTThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTThem.ForeColor = System.Drawing.Color.White;
            this.btnPTThem.Location = new System.Drawing.Point(37, 165);
            this.btnPTThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnPTThem.Name = "btnPTThem";
            this.btnPTThem.Size = new System.Drawing.Size(82, 38);
            this.btnPTThem.TabIndex = 6;
            this.btnPTThem.Text = "Thêm";
            this.btnPTThem.UseVisualStyleBackColor = false;
            this.btnPTThem.Click += new System.EventHandler(this.btnPTThem_Click);
            // 
            // dtpPTNgayTra
            // 
            this.dtpPTNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPTNgayTra.Location = new System.Drawing.Point(316, 24);
            this.dtpPTNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPTNgayTra.Name = "dtpPTNgayTra";
            this.dtpPTNgayTra.Size = new System.Drawing.Size(128, 20);
            this.dtpPTNgayTra.TabIndex = 1;
            // 
            // txtPTMaPhieu
            // 
            this.txtPTMaPhieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPTMaPhieu.Location = new System.Drawing.Point(105, 21);
            this.txtPTMaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtPTMaPhieu.Multiline = true;
            this.txtPTMaPhieu.Name = "txtPTMaPhieu";
            this.txtPTMaPhieu.Size = new System.Drawing.Size(128, 23);
            this.txtPTMaPhieu.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_cbbPTHH);
            this.groupBox3.Controls.Add(this.m_txtPTTienPhat);
            this.groupBox3.Controls.Add(this.m_txtPTsoNgayTre);
            this.groupBox3.Controls.Add(this.m_rtbPTLyDo);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(500, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(325, 217);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vị phạm trả sách";
            // 
            // m_cbbPTHH
            // 
            this.m_cbbPTHH.FormattingEnabled = true;
            this.m_cbbPTHH.Location = new System.Drawing.Point(88, 54);
            this.m_cbbPTHH.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbPTHH.Name = "m_cbbPTHH";
            this.m_cbbPTHH.Size = new System.Drawing.Size(128, 21);
            this.m_cbbPTHH.TabIndex = 6;
            // 
            // m_txtPTTienPhat
            // 
            this.m_txtPTTienPhat.Location = new System.Drawing.Point(88, 84);
            this.m_txtPTTienPhat.Margin = new System.Windows.Forms.Padding(2);
            this.m_txtPTTienPhat.Multiline = true;
            this.m_txtPTTienPhat.Name = "m_txtPTTienPhat";
            this.m_txtPTTienPhat.ReadOnly = true;
            this.m_txtPTTienPhat.Size = new System.Drawing.Size(128, 23);
            this.m_txtPTTienPhat.TabIndex = 5;
            // 
            // m_txtPTsoNgayTre
            // 
            this.m_txtPTsoNgayTre.Location = new System.Drawing.Point(86, 19);
            this.m_txtPTsoNgayTre.Margin = new System.Windows.Forms.Padding(2);
            this.m_txtPTsoNgayTre.Multiline = true;
            this.m_txtPTsoNgayTre.Name = "m_txtPTsoNgayTre";
            this.m_txtPTsoNgayTre.ReadOnly = true;
            this.m_txtPTsoNgayTre.Size = new System.Drawing.Size(128, 23);
            this.m_txtPTsoNgayTre.TabIndex = 5;
            // 
            // m_rtbPTLyDo
            // 
            this.m_rtbPTLyDo.Location = new System.Drawing.Point(64, 118);
            this.m_rtbPTLyDo.Margin = new System.Windows.Forms.Padding(2);
            this.m_rtbPTLyDo.Name = "m_rtbPTLyDo";
            this.m_rtbPTLyDo.Size = new System.Drawing.Size(257, 95);
            this.m_rtbPTLyDo.TabIndex = 1;
            this.m_rtbPTLyDo.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 118);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Lý do:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(31, 58);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Hư hỏng:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 87);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Số tiền phạt:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Số ngày trễ:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(258, 26);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Ngày Trả:";
            // 
            // dgvPhieuTra
            // 
            this.dgvPhieuTra.AllowUserToAddRows = false;
            this.dgvPhieuTra.AllowUserToDeleteRows = false;
            this.dgvPhieuTra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuTra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTra.Location = new System.Drawing.Point(8, 223);
            this.dgvPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuTra.Name = "dgvPhieuTra";
            this.dgvPhieuTra.ReadOnly = true;
            this.dgvPhieuTra.RowTemplate.Height = 24;
            this.dgvPhieuTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuTra.Size = new System.Drawing.Size(823, 281);
            this.dgvPhieuTra.TabIndex = 1;
            this.dgvPhieuTra.Click += new System.EventHandler(this.dgvPhieuTra_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tên sách:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 56);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tên đọc giả:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã phiếu trả:";
            // 
            // cmbPTDocGia
            // 
            this.cmbPTDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTDocGia.FormattingEnabled = true;
            this.cmbPTDocGia.Location = new System.Drawing.Point(104, 52);
            this.cmbPTDocGia.Name = "cmbPTDocGia";
            this.cmbPTDocGia.Size = new System.Drawing.Size(129, 21);
            this.cmbPTDocGia.TabIndex = 9;
            // 
            // cmbPTSach
            // 
            this.cmbPTSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTSach.FormattingEnabled = true;
            this.cmbPTSach.Location = new System.Drawing.Point(104, 89);
            this.cmbPTSach.Name = "cmbPTSach";
            this.cmbPTSach.Size = new System.Drawing.Size(129, 21);
            this.cmbPTSach.TabIndex = 9;
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(2, 170);
            this.dgvPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.RowTemplate.Height = 24;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(955, 334);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.Click += new System.EventHandler(this.dgvPhieuMuon_Click);
            // 
            // ucBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tcMuonTra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucBorrow";
            this.Size = new System.Drawing.Size(969, 535);
            this.Load += new System.EventHandler(this.ucBorrow_Load);
            this.tcMuonTra.ResumeLayout(false);
            this.tpCTPM.ResumeLayout(false);
            this.tpCTPM.PerformLayout();
            this.tpCTPT.ResumeLayout(false);
            this.tpCTPT.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMuonTra;
        private System.Windows.Forms.TabPage tpCTPM;
        private System.Windows.Forms.ComboBox cmbPMDocGia;
        private System.Windows.Forms.Button btnPMXoa;
        private System.Windows.Forms.Button btnPMSua;
        private System.Windows.Forms.Button btnPMThem;
        private System.Windows.Forms.DateTimePicker dtpPMNgayTra;
        private System.Windows.Forms.DateTimePicker dtpPMNgayMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpCTPT;
        private System.Windows.Forms.Button btnPTXoa;
        private System.Windows.Forms.Button btnPTSua;
        private System.Windows.Forms.Button btnPTThem;
        private System.Windows.Forms.DateTimePicker dtpPTNgayTra;
        private System.Windows.Forms.TextBox txtPTMaPhieu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox m_cbbPTHH;
        private System.Windows.Forms.TextBox m_txtPTTienPhat;
        private System.Windows.Forms.TextBox m_txtPTsoNgayTre;
        private System.Windows.Forms.RichTextBox m_rtbPTLyDo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgvPhieuTra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPMSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cmbPTDocGia;
        private System.Windows.Forms.ComboBox cmbPTSach;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
    }
}

namespace _3_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txTenDem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rBtnNam = new System.Windows.Forms.RadioButton();
            this.rBtnNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(12, 282);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowTemplate.Height = 25;
            this.dgvNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanvien.Size = new System.Drawing.Size(776, 156);
            this.dgvNhanvien.TabIndex = 0;
            this.dgvNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ho";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(98, 34);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(173, 23);
            this.txtHo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten dem";
            // 
            // txTenDem
            // 
            this.txTenDem.Location = new System.Drawing.Point(98, 72);
            this.txTenDem.Name = "txTenDem";
            this.txTenDem.Size = new System.Drawing.Size(173, 23);
            this.txTenDem.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ten";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(98, 118);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 23);
            this.txtTen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gioi tinh";
            // 
            // rBtnNam
            // 
            this.rBtnNam.AutoSize = true;
            this.rBtnNam.Location = new System.Drawing.Point(98, 219);
            this.rBtnNam.Name = "rBtnNam";
            this.rBtnNam.Size = new System.Drawing.Size(51, 19);
            this.rBtnNam.TabIndex = 3;
            this.rBtnNam.TabStop = true;
            this.rBtnNam.Text = "Nam";
            this.rBtnNam.UseVisualStyleBackColor = true;
            // 
            // rBtnNu
            // 
            this.rBtnNu.AutoSize = true;
            this.rBtnNu.Location = new System.Drawing.Point(198, 219);
            this.rBtnNu.Name = "rBtnNu";
            this.rBtnNu.Size = new System.Drawing.Size(41, 19);
            this.rBtnNu.TabIndex = 3;
            this.rBtnNu.TabStop = true;
            this.rBtnNu.Text = "Nu";
            this.rBtnNu.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(625, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(625, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(625, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRs
            // 
            this.btnRs.Location = new System.Drawing.Point(625, 150);
            this.btnRs.Name = "btnRs";
            this.btnRs.Size = new System.Drawing.Size(75, 23);
            this.btnRs.TabIndex = 4;
            this.btnRs.Text = "Lam moi";
            this.btnRs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sdt";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(98, 147);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(173, 23);
            this.txtSdt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dia chi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(98, 177);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(173, 23);
            this.txtDiaChi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chuc vu";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(373, 104);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(188, 23);
            this.txtTim.TabIndex = 6;
            this.txtTim.Text = "Tim kiem..";
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(361, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRs);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rBtnNu);
            this.Controls.Add(this.rBtnNam);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txTenDem);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhanvien);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvNhanvien;
        private Label label1;
        private TextBox txtHo;
        private Label label2;
        private TextBox txTenDem;
        private Label label3;
        private TextBox txtTen;
        private Label label4;
        private RadioButton rBtnNam;
        private RadioButton rBtnNu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnRs;
        private Label label5;
        private TextBox txtSdt;
        private Label label6;
        private TextBox txtDiaChi;
        private Button button1;
        private Label label7;
        private TextBox txtTim;
        private DateTimePicker dateTimePicker1;
    }
}
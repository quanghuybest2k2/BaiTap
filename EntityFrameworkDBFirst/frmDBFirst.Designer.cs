
namespace EntityFrameworkDBFirst
{
    partial class frmDBFirst
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
            this.gbDanhSachSV = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textTimKiem = new System.Windows.Forms.TextBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbDanhSachSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDanhSachSV
            // 
            this.gbDanhSachSV.Controls.Add(this.lvDanhSachSV);
            this.gbDanhSachSV.Controls.Add(this.textTimKiem);
            this.gbDanhSachSV.Location = new System.Drawing.Point(12, 145);
            this.gbDanhSachSV.Name = "gbDanhSachSV";
            this.gbDanhSachSV.Size = new System.Drawing.Size(572, 290);
            this.gbDanhSachSV.TabIndex = 12;
            this.gbDanhSachSV.TabStop = false;
            this.gbDanhSachSV.Text = "Danh sách sinh viên";
            // 
            // lvDanhSachSV
            // 
            this.lvDanhSachSV.CheckBoxes = true;
            this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTenSV,
            this.colLop});
            this.lvDanhSachSV.FullRowSelect = true;
            this.lvDanhSachSV.GridLines = true;
            this.lvDanhSachSV.HideSelection = false;
            this.lvDanhSachSV.Location = new System.Drawing.Point(6, 45);
            this.lvDanhSachSV.Name = "lvDanhSachSV";
            this.lvDanhSachSV.Size = new System.Drawing.Size(560, 239);
            this.lvDanhSachSV.TabIndex = 1;
            this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            // 
            // colHoTenSV
            // 
            this.colHoTenSV.Text = "Họ tên Sinh Viên";
            this.colHoTenSV.Width = 126;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 111;
            // 
            // textTimKiem
            // 
            this.textTimKiem.Location = new System.Drawing.Point(385, 19);
            this.textTimKiem.Name = "textTimKiem";
            this.textTimKiem.Size = new System.Drawing.Size(181, 20);
            this.textTimKiem.TabIndex = 0;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(207, 83);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(258, 20);
            this.txtHoTenSV.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(207, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 10;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(207, 15);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(258, 21);
            this.cbbLop.TabIndex = 9;
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(119, 86);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(56, 13);
            this.lblHoTenSV.TabIndex = 6;
            this.lblHoTenSV.Text = "Họ tên SV";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(119, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(119, 18);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(317, 109);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 30);
            this.btnReload.TabIndex = 13;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(417, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(207, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Mặc định";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // frmDBFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.gbDanhSachSV);
            this.Controls.Add(this.txtHoTenSV);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.lblHoTenSV);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Name = "frmDBFirst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên EFDBFirst";
            this.gbDanhSachSV.ResumeLayout(false);
            this.gbDanhSachSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDanhSachSV;
        private System.Windows.Forms.ListView lvDanhSachSV;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTenSV;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.TextBox textTimKiem;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}


﻿
namespace UsingADO.NET
{
    partial class frmADO
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
            this.lblLop = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.gbDanhSachSV = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.gbDanhSachSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(119, 21);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(119, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(119, 89);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(56, 13);
            this.lblHoTenSV.TabIndex = 0;
            this.lblHoTenSV.Text = "Họ tên SV";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(207, 18);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(258, 21);
            this.cbbLop.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(207, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(207, 86);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(258, 20);
            this.txtHoTenSV.TabIndex = 3;
            // 
            // gbDanhSachSV
            // 
            this.gbDanhSachSV.Controls.Add(this.lvDanhSachSV);
            this.gbDanhSachSV.Controls.Add(this.txtTimKiem);
            this.gbDanhSachSV.Location = new System.Drawing.Point(12, 148);
            this.gbDanhSachSV.Name = "gbDanhSachSV";
            this.gbDanhSachSV.Size = new System.Drawing.Size(572, 290);
            this.gbDanhSachSV.TabIndex = 4;
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
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(385, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(181, 20);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(207, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Mặc định";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(417, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(317, 112);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 30);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbDanhSachSV);
            this.Controls.Add(this.txtHoTenSV);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.lblHoTenSV);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblLop);
            this.Name = "frmADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên ADO.NET";
            this.Load += new System.EventHandler(this.frmADO_Load);
            this.gbDanhSachSV.ResumeLayout(false);
            this.gbDanhSachSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.GroupBox gbDanhSachSV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ListView lvDanhSachSV;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTenSV;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
    }
}


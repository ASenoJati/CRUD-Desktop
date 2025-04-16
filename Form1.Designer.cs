namespace CRUD
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
            lblNoID = new Label();
            txtNoID = new TextBox();
            lblNamaDepan = new Label();
            txtNamaDepan = new TextBox();
            lblNamaBelakang = new Label();
            txtNamaBelakang = new TextBox();
            lblNilai = new Label();
            txtNilai = new TextBox();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnCreate = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExportPDF = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNoID
            // 
            lblNoID.AutoSize = true;
            lblNoID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNoID.Location = new Point(49, 58);
            lblNoID.Name = "lblNoID";
            lblNoID.Size = new Size(70, 28);
            lblNoID.TabIndex = 0;
            lblNoID.Text = "NO ID";
            // 
            // txtNoID
            // 
            txtNoID.Location = new Point(248, 62);
            txtNoID.Name = "txtNoID";
            txtNoID.Size = new Size(213, 27);
            txtNoID.TabIndex = 1;
            // 
            // lblNamaDepan
            // 
            lblNamaDepan.AutoSize = true;
            lblNamaDepan.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNamaDepan.Location = new Point(49, 103);
            lblNamaDepan.Name = "lblNamaDepan";
            lblNamaDepan.Size = new Size(148, 28);
            lblNamaDepan.TabIndex = 0;
            lblNamaDepan.Text = "NAMA DEPAN";
            // 
            // txtNamaDepan
            // 
            txtNamaDepan.Location = new Point(248, 107);
            txtNamaDepan.Name = "txtNamaDepan";
            txtNamaDepan.Size = new Size(213, 27);
            txtNamaDepan.TabIndex = 1;
            // 
            // lblNamaBelakang
            // 
            lblNamaBelakang.AutoSize = true;
            lblNamaBelakang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNamaBelakang.Location = new Point(49, 150);
            lblNamaBelakang.Name = "lblNamaBelakang";
            lblNamaBelakang.Size = new Size(186, 28);
            lblNamaBelakang.TabIndex = 0;
            lblNamaBelakang.Text = "NAMA BELAKANG";
            // 
            // txtNamaBelakang
            // 
            txtNamaBelakang.Location = new Point(248, 154);
            txtNamaBelakang.Name = "txtNamaBelakang";
            txtNamaBelakang.Size = new Size(213, 27);
            txtNamaBelakang.TabIndex = 1;
            // 
            // lblNilai
            // 
            lblNilai.AutoSize = true;
            lblNilai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNilai.Location = new Point(49, 199);
            lblNilai.Name = "lblNilai";
            lblNilai.Size = new Size(64, 28);
            lblNilai.TabIndex = 0;
            lblNilai.Text = "NILAI";
            // 
            // txtNilai
            // 
            txtNilai.Location = new Point(248, 203);
            txtNilai.Name = "txtNilai";
            txtNilai.Size = new Size(213, 27);
            txtNilai.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(494, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(681, 274);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(862, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(1081, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCreate.Location = new Point(38, 375);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 46);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(195, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(353, 375);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 46);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(513, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportPDF.Location = new Point(676, 375);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(131, 46);
            btnExportPDF.TabIndex = 3;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.Location = new Point(1076, 388);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 33);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 450);
            Controls.Add(btnClose);
            Controls.Add(btnExportPDF);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtNilai);
            Controls.Add(lblNilai);
            Controls.Add(txtNamaBelakang);
            Controls.Add(lblNamaBelakang);
            Controls.Add(txtNamaDepan);
            Controls.Add(lblNamaDepan);
            Controls.Add(txtSearch);
            Controls.Add(txtNoID);
            Controls.Add(lblNoID);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNoID;
        private TextBox txtNoID;
        private Label lblNamaDepan;
        private TextBox txtNamaDepan;
        private Label lblNamaBelakang;
        private TextBox txtNamaBelakang;
        private Label lblNilai;
        private TextBox txtNilai;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExportPDF;
        private Button btnClose;
    }
}

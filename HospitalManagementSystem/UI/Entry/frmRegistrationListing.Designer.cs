namespace HospitalManagementSystem.UI.Entry
{
    partial class frmRegistrationListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRegList = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRegistration = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colRowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaritalStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlRegList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegList
            // 
            this.pnlRegList.Controls.Add(this.dgvRegistration);
            this.pnlRegList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegList.Location = new System.Drawing.Point(0, 0);
            this.pnlRegList.Name = "pnlRegList";
            this.pnlRegList.Size = new System.Drawing.Size(881, 450);
            this.pnlRegList.TabIndex = 0;
            // 
            // dgvRegistration
            // 
            this.dgvRegistration.AllowUserToAddRows = false;
            this.dgvRegistration.AllowUserToDeleteRows = false;
            this.dgvRegistration.AllowUserToResizeColumns = false;
            this.dgvRegistration.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRegistration.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistration.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistration.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistration.ColumnHeadersHeight = 40;
            this.dgvRegistration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRowNo,
            this.colId,
            this.colNameTypeId,
            this.colName,
            this.colFullName,
            this.colDob,
            this.colGender,
            this.colMaritalStatusId,
            this.colMaritalStatus,
            this.colFatherName,
            this.colPhoneNo,
            this.colDelete});
            this.dgvRegistration.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistration.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistration.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistration.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistration.Name = "dgvRegistration";
            this.dgvRegistration.ReadOnly = true;
            this.dgvRegistration.RowHeadersVisible = false;
            this.dgvRegistration.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegistration.Size = new System.Drawing.Size(881, 450);
            this.dgvRegistration.TabIndex = 0;
            this.dgvRegistration.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistration.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRegistration.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRegistration.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRegistration.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRegistration.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistration.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistration.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRegistration.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistration.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegistration.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegistration.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegistration.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvRegistration.ThemeStyle.ReadOnly = true;
            this.dgvRegistration.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistration.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistration.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegistration.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegistration.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRegistration.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistration.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegistration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistration_CellContentClick);
            this.dgvRegistration.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistration_CellDoubleClick);
            // 
            // colRowNo
            // 
            this.colRowNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRowNo.DataPropertyName = "RowNo";
            this.colRowNo.FillWeight = 177.665F;
            this.colRowNo.HeaderText = "S/N";
            this.colRowNo.MaxInputLength = 100;
            this.colRowNo.Name = "colRowNo";
            this.colRowNo.ReadOnly = true;
            this.colRowNo.Width = 50;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNameTypeId
            // 
            this.colNameTypeId.DataPropertyName = "NameTypeId";
            this.colNameTypeId.HeaderText = "NameTypeId";
            this.colNameTypeId.Name = "colNameTypeId";
            this.colNameTypeId.ReadOnly = true;
            this.colNameTypeId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Visible = false;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.FillWeight = 87.05584F;
            this.colFullName.HeaderText = "Full Name";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colDob
            // 
            this.colDob.DataPropertyName = "Dob";
            this.colDob.FillWeight = 87.05584F;
            this.colDob.HeaderText = "Birth Date";
            this.colDob.Name = "colDob";
            this.colDob.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.FillWeight = 87.05584F;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colMaritalStatusId
            // 
            this.colMaritalStatusId.DataPropertyName = "MaritalStatusId";
            this.colMaritalStatusId.HeaderText = "MaritalStatusId";
            this.colMaritalStatusId.Name = "colMaritalStatusId";
            this.colMaritalStatusId.ReadOnly = true;
            this.colMaritalStatusId.Visible = false;
            // 
            // colMaritalStatus
            // 
            this.colMaritalStatus.DataPropertyName = "MaritalStatus";
            this.colMaritalStatus.FillWeight = 87.05584F;
            this.colMaritalStatus.HeaderText = "Marital Status";
            this.colMaritalStatus.Name = "colMaritalStatus";
            this.colMaritalStatus.ReadOnly = true;
            // 
            // colFatherName
            // 
            this.colFatherName.DataPropertyName = "FatherName";
            this.colFatherName.FillWeight = 87.05584F;
            this.colFatherName.HeaderText = "Father Name";
            this.colFatherName.Name = "colFatherName";
            this.colFatherName.ReadOnly = true;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.DataPropertyName = "PhoneNo";
            this.colPhoneNo.FillWeight = 87.05584F;
            this.colPhoneNo.HeaderText = "Phone No";
            this.colPhoneNo.Name = "colPhoneNo";
            this.colPhoneNo.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "X";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 70;
            // 
            // frmRegistrationListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.pnlRegList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrationListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrationListing";
            this.Load += new System.EventHandler(this.frmRegistrationListing_Load);
            this.pnlRegList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlRegList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaritalStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaritalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNo;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
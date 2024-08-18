namespace HospitalManagementSystem.UI.Entry
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDbo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhno = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlRegImage = new Guna.UI2.WinForms.Guna2Panel();
            this.rdoFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.cboNameType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMariStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderRadius = 5;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtName.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtName.Location = new System.Drawing.Point(210, 366);
            this.txtName.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(147, 36);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 382);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name ";
            // 
            // dtpDbo
            // 
            this.dtpDbo.BackColor = System.Drawing.Color.White;
            this.dtpDbo.BorderRadius = 5;
            this.dtpDbo.Checked = true;
            this.dtpDbo.CustomFormat = "dd-MM-yyyy";
            this.dtpDbo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpDbo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dtpDbo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDbo.Location = new System.Drawing.Point(517, 363);
            this.dtpDbo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDbo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDbo.Name = "dtpDbo";
            this.dtpDbo.Size = new System.Drawing.Size(224, 36);
            this.dtpDbo.TabIndex = 3;
            this.dtpDbo.Value = new System.DateTime(2024, 8, 10, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(416, 382);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 17);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Date of Birth ";
            // 
            // txtPhNo
            // 
            this.txtPhNo.BackColor = System.Drawing.Color.White;
            this.txtPhNo.BorderRadius = 5;
            this.txtPhNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPhNo.DefaultText = "";
            this.txtPhNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtPhNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhNo.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtPhNo.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPhNo.Location = new System.Drawing.Point(517, 477);
            this.txtPhNo.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.PasswordChar = '\0';
            this.txtPhNo.PlaceholderText = "";
            this.txtPhNo.SelectedText = "";
            this.txtPhNo.Size = new System.Drawing.Size(224, 36);
            this.txtPhNo.TabIndex = 1;
            // 
            // lblPhno
            // 
            this.lblPhno.BackColor = System.Drawing.Color.Transparent;
            this.lblPhno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhno.Location = new System.Drawing.Point(416, 493);
            this.lblPhno.Name = "lblPhno";
            this.lblPhno.Size = new System.Drawing.Size(87, 17);
            this.lblPhno.TabIndex = 5;
            this.lblPhno.Text = "Phone Number";
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.Color.White;
            this.pnlRegister.Controls.Add(this.btnCancel);
            this.pnlRegister.Controls.Add(this.btnSave);
            this.pnlRegister.Controls.Add(this.pnlRegImage);
            this.pnlRegister.Controls.Add(this.rdoFemale);
            this.pnlRegister.Controls.Add(this.rdoMale);
            this.pnlRegister.Controls.Add(this.cboNameType);
            this.pnlRegister.Controls.Add(this.cboMariStatus);
            this.pnlRegister.Controls.Add(this.lblStatus);
            this.pnlRegister.Controls.Add(this.lblFname);
            this.pnlRegister.Controls.Add(this.lblGender);
            this.pnlRegister.Controls.Add(this.txtName);
            this.pnlRegister.Controls.Add(this.lblPhno);
            this.pnlRegister.Controls.Add(this.txtFname);
            this.pnlRegister.Controls.Add(this.txtPhNo);
            this.pnlRegister.Controls.Add(this.guna2HtmlLabel1);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.dtpDbo);
            this.pnlRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegister.FillColor = System.Drawing.Color.White;
            this.pnlRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(787, 639);
            this.pnlRegister.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(184, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(459, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Register";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlRegImage
            // 
            this.pnlRegImage.BackColor = System.Drawing.Color.White;
            this.pnlRegImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRegImage.BackgroundImage")));
            this.pnlRegImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlRegImage.BorderColor = System.Drawing.Color.White;
            this.pnlRegImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRegImage.Location = new System.Drawing.Point(0, 0);
            this.pnlRegImage.Name = "pnlRegImage";
            this.pnlRegImage.Size = new System.Drawing.Size(787, 321);
            this.pnlRegImage.TabIndex = 10;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.White;
            this.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.BorderThickness = 0;
            this.rdoFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoFemale.CheckedState.InnerOffset = -4;
            this.rdoFemale.Location = new System.Drawing.Point(250, 440);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 9;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoFemale.UncheckedState.BorderThickness = 2;
            this.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.White;
            this.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.BorderThickness = 0;
            this.rdoMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMale.CheckedState.InnerOffset = -4;
            this.rdoMale.Location = new System.Drawing.Point(140, 440);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.Text = "Male";
            this.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMale.UncheckedState.BorderThickness = 2;
            this.rdoMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // cboNameType
            // 
            this.cboNameType.BackColor = System.Drawing.Color.White;
            this.cboNameType.BorderRadius = 5;
            this.cboNameType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNameType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNameType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNameType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNameType.ItemHeight = 30;
            this.cboNameType.Location = new System.Drawing.Point(133, 366);
            this.cboNameType.Name = "cboNameType";
            this.cboNameType.Size = new System.Drawing.Size(75, 36);
            this.cboNameType.TabIndex = 8;
            // 
            // cboMariStatus
            // 
            this.cboMariStatus.BackColor = System.Drawing.Color.White;
            this.cboMariStatus.BorderRadius = 5;
            this.cboMariStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMariStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMariStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMariStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMariStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMariStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboMariStatus.ItemHeight = 30;
            this.cboMariStatus.Location = new System.Drawing.Point(517, 421);
            this.cboMariStatus.Name = "cboMariStatus";
            this.cboMariStatus.Size = new System.Drawing.Size(224, 36);
            this.cboMariStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(416, 440);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(77, 17);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Marital Status";
            // 
            // lblFname
            // 
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(36, 493);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(75, 17);
            this.lblFname.TabIndex = 6;
            this.lblFname.Text = "Father Name";
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(36, 440);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(44, 17);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.White;
            this.txtFname.BorderRadius = 5;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFname.DefaultText = "";
            this.txtFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFname.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtFname.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtFname.Location = new System.Drawing.Point(133, 474);
            this.txtFname.Margin = new System.Windows.Forms.Padding(0);
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.PlaceholderText = "";
            this.txtFname.SelectedText = "";
            this.txtFname.Size = new System.Drawing.Size(224, 36);
            this.txtFname.TabIndex = 1;
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 639);
            this.Controls.Add(this.pnlRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDbo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhno;
        private Guna.UI2.WinForms.Guna2Panel pnlRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGender;
        private Guna.UI2.WinForms.Guna2ComboBox cboMariStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFname;
        private Guna.UI2.WinForms.Guna2TextBox txtFname;
        private Guna.UI2.WinForms.Guna2ComboBox cboNameType;
        private Guna.UI2.WinForms.Guna2RadioButton rdoFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMale;
        private Guna.UI2.WinForms.Guna2Panel pnlRegImage;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
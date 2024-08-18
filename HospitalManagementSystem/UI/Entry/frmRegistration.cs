using HospitalManagementSystem.Common;
using HospitalManagementSystem.DAO;
using HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Entry
{
    public partial class frmRegistration : Form
    {
        int regId = 0;
        MessageEntity message = new MessageEntity();
        RegistrationEntity registration = new RegistrationEntity();

        public frmRegistration()
        {
            InitializeComponent();
        }

        public frmRegistration(RegistrationEntity _reg)
        {
            InitializeComponent();
            registration = _reg;
            if (registration.Id != 0)
            {
                regId = registration.Id;
                cboNameType.SelectedValue = registration.NameTypeId;
                txtName.Text = registration.Name;
                dtpDbo.Value = registration.Dob;
                txtPhNo.Text = registration.PhoneNo;
                txtFname.Text = registration.FatherName;
                cboMariStatus.SelectedValue = registration.MaritalStatusId;
                if (registration.Gender == "Male")
                {
                    rdoMale.Checked = true;
                    rdoFemale.Checked = false;
                }
                else
                {
                    rdoMale.Checked = false;
                    rdoFemale.Checked = true;
                }

                btnSave.Text = "Update";
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            GetComboData();
            if (regId == 0)
            {
                dtpDbo.Value = DateTime.Today;
                rdoMale.Checked = true;
            }
            if (regId !=0)
            {
                regId = registration.Id;
                cboNameType.SelectedValue = registration.NameTypeId;
                txtName.Text = registration.Name;
                dtpDbo.Value = registration.Dob;
                txtPhNo.Text = registration.PhoneNo;
                txtFname.Text = registration.FatherName;
                cboMariStatus.SelectedValue = registration.MaritalStatusId;
                if (registration.Gender == "Male")
                {
                    rdoMale.Checked = true;
                    rdoFemale.Checked = false;
                }
                else
                {
                    rdoMale.Checked = false;
                    rdoFemale.Checked = true;
                }

                btnSave.Text = "Update";
            }
        }

        private void GetComboData()
        {
            try
            {
                ResRegistration resRegistration = new RegistrationDao().GetComboData();
                if (resRegistration != null)
                {
                    if (resRegistration.msgEntity.RespMessageType == "MS")
                    {
                        cboNameType.DataSource = null;
                        cboNameType.DataSource = resRegistration.lstNameType;
                        cboNameType.DisplayMember = "Type";
                        cboNameType.ValueMember = "Id";

                        cboMariStatus.DataSource = null;
                        cboMariStatus.DataSource = resRegistration.lstMaritalStatus;
                        cboMariStatus.DisplayMember = "Name";
                        cboMariStatus.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;

                if (regId == 0)
                {
                    RegistrationEntity reg = new RegistrationEntity()
                    {
                        Name = txtName.Text.Trim(),
                        Dob = dtpDbo.Value,
                        PhoneNo = txtPhNo.Text.Trim(),
                        FatherName = txtFname.Text.Trim(),
                        MaritalStatusId = Convert.ToInt32(cboMariStatus.SelectedValue),
                        Gender = rdoMale.Checked ? "Male" : "Female",
                        NameTypeId = Convert.ToInt32(cboNameType.SelectedValue)
                    };

                    message = new RegistrationDao().Save(reg);
                }
                else
                {
                    RegistrationEntity reg = new RegistrationEntity()
                    {
                        Id=regId,
                        Name = txtName.Text.Trim(),
                        Dob = dtpDbo.Value,
                        PhoneNo = txtPhNo.Text.Trim(),
                        FatherName = txtFname.Text.Trim(),
                        MaritalStatusId = Convert.ToInt32(cboMariStatus.SelectedValue),
                        Gender = rdoMale.Checked ? "Male" : "Female",
                        NameTypeId = Convert.ToInt32(cboNameType.SelectedValue)
                    };

                    message = new RegistrationDao().Update(reg);
                }

                if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show(message.RespDesc);
                    ClearAll();
                    txtName.Select();
                    regId= 0;
                }
                else
                {
                    MessageBox.Show(message.RespDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please, fill patient name!");
                txtName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(cboMariStatus.Text))
            {
                MessageBox.Show("Please, select marital status!");
                cboMariStatus.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                MessageBox.Show("Please, fill father name!");
                txtFname.Select();
                return false;
            }
            if (string.IsNullOrEmpty(txtPhNo.Text))
            {
                MessageBox.Show("Please, fill phone number!");
                txtPhNo.Select();
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            txtName.Clear();
            txtName.Select();
            dtpDbo.Value = DateTime.Now;
            txtPhNo.Clear();
            txtFname.Clear();
            rdoMale.Checked = true;
            cboMariStatus.SelectedIndex = 0;
            cboNameType.SelectedIndex = 0;
            btnSave.Text = "Register";
            regId = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

    }
}

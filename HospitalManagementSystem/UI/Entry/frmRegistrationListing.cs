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
    public partial class frmRegistrationListing : Form
    {
        int RegistrationId = 0;
        private frmMain _mainForm;
        MessageEntity message = new MessageEntity();

        //public frmRegistrationListing()
        //{
        //    InitializeComponent();
        //}

        public frmRegistrationListing(frmMain mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void frmRegistrationListing_Load(object sender, EventArgs e)
        {
            dgvRegistration.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            ResRegistration resRegistration = new ResRegistration();
            try
            {
                resRegistration = new RegistrationDao().GetAllRegistrationData();
                if (resRegistration != null && resRegistration.lstRegistration.Count > 0)
                {
                    dgvRegistration.DataSource = resRegistration.lstRegistration;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(resRegistration.msgEntity.RespDesc);
            }
        }

        private void dgvRegistration_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvRegistration.SelectedRows[0];
                RegistrationEntity reg = new RegistrationEntity()
                {
                    Id = Convert.ToInt32(dgvRow.Cells["colId"].Value),
                    Name = dgvRow.Cells["colName"].Value.ToString(),
                    Dob = Convert.ToDateTime(dgvRow.Cells["colDob"].Value),
                    PhoneNo = dgvRow.Cells["colPhoneNo"].Value.ToString(),
                    FatherName = dgvRow.Cells["colFatherName"].Value.ToString(),
                    MaritalStatusId = Convert.ToInt32(dgvRow.Cells["colMaritalStatusId"].Value),
                    Gender = dgvRow.Cells["colGender"].Value.ToString(),
                    NameTypeId = Convert.ToInt32(dgvRow.Cells["colNameTypeId"].Value)
                };

                frmRegistration frm = new frmRegistration(reg);
                _mainForm.openChildForm(frm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dgvRegistration.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        RegistrationId = Convert.ToInt32(dgvRegistration.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new RegistrationDao().Delete(RegistrationId);
                        if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show(message.RespDesc);
                            BindDataGridView();
                        }
                        else
                        {
                            MessageBox.Show(message.RespDesc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

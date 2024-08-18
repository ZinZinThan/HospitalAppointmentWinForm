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

namespace HospitalManagementSystem.UI.Configuration
{
    public partial class frmMaritalStatus : Form
    {
        int statusId = 0;
        MessageEntity message = new MessageEntity();

        public frmMaritalStatus()
        {
            InitializeComponent();
        }

        private void frmMaritalStatus_Load(object sender, EventArgs e)
        {
            txtMaritalStatus.Select();
            dgvMaritalStatus.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaritalStatus.Clear();
            txtMaritalStatus.Select();
            btnSave.Text = "Save";
            statusId = 0;
        }

        private void BindDataGridView()
        {
            ResMaritalStatus status = new ResMaritalStatus();
            try
            {
                status = new MaritalStatusDao().GetAllMaritalStatus();
                if (status != null && status.lstMaritalStatus.Count > 0)
                {
                    dgvMaritalStatus.DataSource = status.lstMaritalStatus;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(status.msgEntity.RespDesc);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaritalStatus.Text))
                {
                    MessageBox.Show("Please, fill marital status.");
                    txtMaritalStatus.Select();
                    return;
                }

                if (statusId == 0)
                {
                    MaritalStatusEntity statusEntity = new MaritalStatusEntity() { Name = txtMaritalStatus.Text.Trim() };
                    message = new MaritalStatusDao().Save(statusEntity);
                }
                else
                {
                    MaritalStatusEntity statusEntity = new MaritalStatusEntity() 
                    { 
                        Id= statusId,
                        Name = txtMaritalStatus.Text.Trim() 
                    };

                    message = new MaritalStatusDao().Update(statusEntity);
                }

                if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show(message.RespDesc);
                    txtMaritalStatus.Clear();
                    txtMaritalStatus.Select();
                    statusId = 0;
                    BindDataGridView();
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

        private void dgvMaritalStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvMaritalStatus.SelectedRows[0];

                statusId = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                txtMaritalStatus.Text = dgvRow.Cells["colName"].Value.ToString();
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMaritalStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dgvMaritalStatus.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        statusId = Convert.ToInt32(dgvMaritalStatus.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new RegistrationDao().Delete(statusId);
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

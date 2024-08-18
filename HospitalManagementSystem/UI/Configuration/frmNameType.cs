using HospitalManagementSystem.Common;
using HospitalManagementSystem.DAO;
using HospitalManagementSystem.Entity;
using HospitalManagementSystem.UI.Entry;
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
    public partial class frmNameType : Form
    {
        int nameTypeId=0;
        MessageEntity message =new MessageEntity();

        public frmNameType()
        {
            InitializeComponent();
        }

        private void FrmNameType_Load(object sender, EventArgs e)
        {
            txtNameType.Select();
            dgvNameType.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNameType.Clear();
            txtNameType.Select();
            btnSave.Text = "Save";
            nameTypeId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameType.Text)) 
                {
                    MessageBox.Show("Please, fill name type.");
                    txtNameType.Select();
                    return;
                }

                if(nameTypeId == 0)
                {
                    NameTypeEntity nameType = new NameTypeEntity() { Type = txtNameType.Text.Trim() };
                    message = new NameTypeDao().Save(nameType);
                }
                else
                {
                    NameTypeEntity nameType = new NameTypeEntity() 
                    { 
                        Id= nameTypeId,
                        Type = txtNameType.Text.Trim() 
                    };

                    message = new NameTypeDao().Update(nameType);
                }

                if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show(message.RespDesc);
                    txtNameType.Clear();
                    btnSave.Text = "Save";
                    txtNameType.Select();
                    nameTypeId = 0;
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

        private void dgvNameType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvNameType.SelectedRows[0];

                nameTypeId = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                txtNameType.Text = dgvRow.Cells["colType"].Value.ToString();
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNameType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dgvNameType.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        nameTypeId = Convert.ToInt32(dgvNameType.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new RegistrationDao().Delete(nameTypeId);
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

        private void BindDataGridView()
        {
            ResNameType nameType = new ResNameType();
            try
            {
                nameType = new NameTypeDao().GetAllNameType();
                if (nameType != null && nameType.lstNameType.Count > 0)
                {
                    dgvNameType.DataSource = nameType.lstNameType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(nameType.msgEntity.RespDesc);
            }
        }

    }
}

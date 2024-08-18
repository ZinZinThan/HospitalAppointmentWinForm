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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static HospitalManagementSystem.Common.CommonFormat;

namespace HospitalManagementSystem.UI
{
    public partial class frmUser : Form
    {
        int userId = 0;
        MessageEntity message = new MessageEntity();
        UserEntity userEntity = new UserEntity();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
            GetComboData();
            dgvUser.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void GetComboData()
        {
            try
            {
                ResUserEntity resUser = new UserDao().GetComboData();
                cboRole.DataSource = null;
                if (resUser != null)
                {
                    if (resUser.messageEntity.RespMessageType == "MS")
                    {
                        cboRole.DataSource = resUser.lstRole;
                        cboRole.DisplayMember = "RoleName";
                        cboRole.ValueMember = "Id";
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
            ResUserEntity resUser = new ResUserEntity();
            try
            {
                resUser = new UserDao().GetAllData();
                if (resUser != null && resUser.lstUser.Count > 0)
                {
                    dgvUser.DataSource = resUser.lstUser;
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

                if (userId == 0)
                {
                    userEntity = new UserEntity()
                    {
                        Username = txtUserName.Text.Trim(),
                        LoginName = txtLoginName.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        RoleId = Convert.ToInt32(cboRole.SelectedValue)
                    };

                    message = new UserDao().Save(userEntity);
                }
                else
                {
                    userEntity = new UserEntity()
                    {
                        Id = userId,
                        Username = txtUserName.Text.Trim(),
                        LoginName = txtLoginName.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        RoleId = Convert.ToInt32(cboRole.SelectedValue)
                    };

                    message = new UserDao().Update(userEntity);
                }

                if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show(message.RespDesc);
                    ClearAll();
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

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please,fill user name.");
                return false;
            }

            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                MessageBox.Show("Please,fill Login name.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please,fill password.");
                return false;
            }
            if (cboRole.Text == "Select One...")
            {
                MessageBox.Show("Please, select user role!");
                cboRole.DroppedDown = true;
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            txtUserName.Clear();
            txtLoginName.Clear();
            txtPassword.Clear();
            cboRole.SelectedIndex = 0;
            btnSave.Text = "Save";
            userId = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvUser.SelectedRows[0];

                txtUserName.Text = dgvRow.Cells["colUserName"].Value.ToString();
                txtLoginName.Text = dgvRow.Cells["colLoginName"].Value.ToString();
                txtPassword.Text = dgvRow.Cells["colPassword"].Value.ToString();
                cboRole.SelectedValue = Convert.ToInt32(dgvRow.Cells["colRole"].Value);
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                if (dgvUser.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        userId = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new UserDao().Delete(userId);
                        if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                        {
                            MessageBox.Show(message.RespDesc);
                            ClearAll();
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

using HospitalManagementSystem.Common;
using HospitalManagementSystem.DAO;
using HospitalManagementSystem.Entity;
using HospitalManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HospitalManagementSystem.Common.CommonFormat;

namespace HospitalManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidationFields()) return;
                ResUserEntity resUser = new UserDao().Login(new UserEntity()
                {
                    LoginName = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                });
                if (resUser != null)
                {
                    if (resUser.messageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                    {
                        MessageBox.Show(resUser.messageEntity.RespDesc);
                        this.Hide();
                        CommonFormat.LoginId = resUser.User.Id;
                        CommonFormat.RoleId = resUser.User.RoleId;
                        frmMain main = new frmMain();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show(resUser.messageEntity.RespDesc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private bool CheckValidationFields()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please, fill the User Name.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please, fill the Password.");
                return false;
            }
            return true;
        }
    }
}

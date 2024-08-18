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
    public partial class frmSpeciality : Form
    {
        int specialityId = 0;
        MessageEntity message = new MessageEntity();

        public frmSpeciality()
        {
            InitializeComponent();
        }

        private void frmSpeciality_Load(object sender, EventArgs e)
        {
            txtSpeciality.Select();
            dgvSpeciality.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSpeciality.Text))
                {
                    MessageBox.Show("Please, fill speciality name.");
                    txtSpeciality.Select();
                    return;
                }

                if (specialityId == 0)
                {
                    SpecialityEntity speciality= new SpecialityEntity() { SpecialityName = txtSpeciality.Text.Trim() };
                    message = new SpecialityDao().Save(speciality);
                }
                else
                {
                    SpecialityEntity speciality = new SpecialityEntity()
                    {
                        Id = specialityId,
                        SpecialityName = txtSpeciality.Text.Trim()
                    };

                    message = new SpecialityDao().Update(speciality);
                }

                if (message.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    MessageBox.Show(message.RespDesc);
                    txtSpeciality.Clear();
                    btnSave.Text = "Save";
                    txtSpeciality.Select();
                    specialityId = 0;
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

        private void BindDataGridView()
        {
            ResSpecialityEntity speciality = new ResSpecialityEntity();
            try
            {
                speciality = new SpecialityDao().GetAllSpeciality();
                if (speciality != null && speciality.lstSpeciality.Count > 0)
                {
                    dgvSpeciality.DataSource = speciality.lstSpeciality;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(speciality.msgEntity.RespDesc);
            }
        }

        private void dgvSpeciality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dgvSpeciality.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        specialityId = Convert.ToInt32(dgvSpeciality.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new SpecialityDao().Delete(specialityId);
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

        private void dgvSpeciality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvSpeciality.SelectedRows[0];

                specialityId = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                txtSpeciality.Text = dgvRow.Cells["colSpeciality"].Value.ToString();
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSpeciality.Clear();
            txtSpeciality.Select();
            btnSave.Text = "Save";
            specialityId = 0;
        }
    }
}

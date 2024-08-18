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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystem.UI.Configuration
{
    public partial class frmDoctor : Form
    {
        int doctorId = 0;
        MessageEntity message = new MessageEntity();
        DoctorEntity doctorEntity = new DoctorEntity();

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            txtDoctorName.Select();
            dgvDoctor.AutoGenerateColumns = false;
            BindDataGridView();
            GetComboData();
        }

        private void GetComboData()
        {
            try
            {
                ResDoctorEntity resSpeciality = new DoctorDao().GetComboData();
                if (resSpeciality != null)
                {
                    if (resSpeciality.messageEntity.RespMessageType == "MS")
                    {
                        cboSpeciality.DataSource = null;
                        cboSpeciality.DataSource = resSpeciality.lstSpeciality;
                        cboSpeciality.DisplayMember = "SpecialityName";
                        cboSpeciality.ValueMember = "Id";
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
            ResDoctorEntity doctor = new ResDoctorEntity();
            try
            {
                doctor = new DoctorDao().GetAllDoctor();
                if (doctor != null && doctor.lstDoctor.Count > 0)
                {
                    dgvDoctor.DataSource = doctor.lstDoctor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(doctor.messageEntity.RespDesc);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;

                if (doctorId == 0)
                {
                    doctorEntity = new DoctorEntity()
                    {
                        Name = txtDoctorName.Text.Trim(),
                        SpecialityId = Convert.ToInt32(cboSpeciality.SelectedValue),
                        DoctorFees = Convert.ToInt32(txtFees.Text.Trim())
                    };

                    message = new DoctorDao().Save(doctorEntity);
                }
                else
                {
                    doctorEntity = new DoctorEntity()
                    {
                        Id = doctorId,
                        Name = txtDoctorName.Text.Trim(),
                        SpecialityId = Convert.ToInt32(cboSpeciality.SelectedValue),
                        DoctorFees = Convert.ToInt32(txtFees.Text.Trim())
                    };

                    message = new DoctorDao().Update(doctorEntity);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtDoctorName.Clear();
            txtDoctorName.Select();
            txtFees.Clear();
            cboSpeciality.SelectedIndex = 0;
            btnSave.Text = "Save";
            doctorId = 0;
        }

        private bool CheckRequireFields()
        {
            if (string.IsNullOrEmpty(txtDoctorName.Text))
            {
                MessageBox.Show("Please, fill doctor name!");
                txtDoctorName.Select();
                return false;
            }
            if (string.IsNullOrEmpty(cboSpeciality.Text))
            {
                MessageBox.Show("Please, select speciality!");
                cboSpeciality.DroppedDown = true;
                return false;
            }
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                MessageBox.Show("Please, fill doctor fees!");
                txtFees.Select();
                return false;
            }

            return true;
        }

        private void dgvDoctor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvDoctor.SelectedRows[0];

                doctorId = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                txtDoctorName.Text = dgvRow.Cells["colDoctorName"].Value.ToString();
                cboSpeciality.SelectedValue = Convert.ToInt32(dgvRow.Cells["colSpecialityId"].Value);
                txtFees.Text = dgvRow.Cells["colFees"].Value.ToString();
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                if (dgvDoctor.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        doctorId = Convert.ToInt32(dgvDoctor.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new DoctorDao().Delete(doctorId);
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

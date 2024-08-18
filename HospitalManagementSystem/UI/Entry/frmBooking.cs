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

namespace HospitalManagementSystem.UI.Entry
{
    public partial class frmBooking : Form
    {
        int bookingId = 0;
        BookingEntity bookingEntity = new BookingEntity();
        MessageEntity message = new MessageEntity();

        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            dtpBooking.Value= DateTime.Now;
            GetComboData();
            dgvBooking.AutoGenerateColumns = false;
            BindDataGridView();
        }

        private void GetComboData()
        {
            try
            {
                ResBooking resBooking = new BookingDao().GetComboData();
                cboPatient.DataSource = null;
                cboDoctor.DataSource = null;
                if (resBooking != null)
                {
                    if (resBooking.messageEntity.RespMessageType == "MS")
                    {
                        cboPatient.DataSource = resBooking.lstRegistration;
                        cboPatient.DisplayMember = "FullName";
                        cboPatient.ValueMember = "Id";

                        cboDoctor.DataSource = resBooking.lstDoctor;
                        cboDoctor.DisplayMember = "Name";
                        cboDoctor.ValueMember = "Id";
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
            ResBooking resbooking = new ResBooking();
            try
            {
                resbooking = new BookingDao().GetAllBookingData();
                if (resbooking != null && resbooking.lstBooking.Count > 0)
                {
                    dgvBooking.DataSource = resbooking.lstBooking;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resbooking.messageEntity.RespDesc);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckRequireFields()) return;

                if (bookingId == 0)
                {
                    bookingEntity = new BookingEntity()
                    {
                        DoctorId = Convert.ToInt32(cboDoctor.SelectedValue),
                        RegistrationId = Convert.ToInt32(cboPatient.SelectedValue),
                        BookingDate = Convert.ToDateTime(dtpBooking.Value),
                        CreatedBy = 1
                    };

                    message = new BookingDao().Save(bookingEntity);
                }
                else
                {
                    bookingEntity = new BookingEntity()
                    {
                        Id = bookingId,
                        DoctorId = Convert.ToInt32(cboDoctor.SelectedValue),
                        RegistrationId = Convert.ToInt32(cboPatient.SelectedValue),
                        BookingDate = Convert.ToDateTime(dtpBooking.Value),
                        ModifiedBy = 2
                    };

                    message = new BookingDao().Update(bookingEntity);
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

        private bool CheckRequireFields()
        {
            if (cboPatient.Text == "Select One...")
            {
                MessageBox.Show("Please, select patient name!");
                cboPatient.DroppedDown = true;
                return false;
            }
            if (cboDoctor.Text == "Select One...")
            {
                MessageBox.Show("Please, select doctor name!");
                cboDoctor.DroppedDown = true;
                return false;
            }
            if (dtpBooking.Value < DateTime.Now)
            {
                MessageBox.Show("Booking date shouldn't less than today date!");
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            dtpBooking.Value = DateTime.Now;
            cboDoctor.SelectedIndex = 0;
            cboPatient.SelectedIndex = 0;
            btnSave.Text = "Save";
            bookingId = 0;
        }

        private void dgvBooking_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvRow = dgvBooking.SelectedRows[0];

                bookingId = Convert.ToInt32(dgvRow.Cells["colId"].Value);
                cboDoctor.SelectedValue = Convert.ToInt32(dgvRow.Cells["colDoctorId"].Value);
                cboPatient.SelectedValue = Convert.ToInt32(dgvRow.Cells["colRegistrationId"].Value);
                dtpBooking.Value = Convert.ToDateTime(dgvRow.Cells["colBooking"].Value);
                btnSave.Text = "Update";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;

                if (dgvBooking.Rows[e.RowIndex].Cells["colDelete"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to delete?", "Confirm Delete!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bookingId = Convert.ToInt32(dgvBooking.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new BookingDao().Delete(bookingId);
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

                if (dgvBooking.Rows[e.RowIndex].Cells["colStatus"].ColumnIndex == e.ColumnIndex)
                {
                    var confirmResult = MessageBox.Show("Are you sure want to complete it?", "Confirm Message!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        bookingId = Convert.ToInt32(dgvBooking.Rows[e.RowIndex].Cells["colId"].Value);
                        message = new BookingDao().UpdateStatus(bookingId);
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

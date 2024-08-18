using HospitalManagementSystem.Common;
using HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAO
{
    public class BookingDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResBooking GetAllBookingData()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllBookingData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<BookingEntity> lst = new List<BookingEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    BookingEntity booking = new BookingEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        DoctorId = Convert.ToInt32(dr["DoctorId"]),
                        Name = dr["Name"].ToString(),
                        RegistrationId = Convert.ToInt32(dr["RegistrationId"]),
                        PatientName = dr["PatientName"].ToString(),
                        BookingDate = Convert.ToDateTime(dr["BookingDate"]),
                        Status = dr["Status"].ToString()
                    };
                    lst.Add(booking);
                }

                return new ResBooking()
                {
                    lstBooking = lst
                };
            }
            catch (Exception ex)
            {
                return new ResBooking()
                {
                    messageEntity = new MessageEntity()
                    {
                        RespCode = CommonResponseMessage.ResErrorCode,
                        RespDesc = ex.Message,
                        RespMessageType = CommonResponseMessage.ResErrorType
                    }
                };
            }
        }

        public ResBooking GetComboData()
        {
            List<RegistrationEntity> lstRegistration = new List<RegistrationEntity>();
            List<DoctorEntity> lstDoctor = new List<DoctorEntity>();
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllBookingComboData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null)
                {
                    DataTable dtReg = ds.Tables[0];
                    DataTable dtDoctor = ds.Tables[1];

                    lstRegistration.Add(new RegistrationEntity()
                    {
                        Id = 0,
                        FullName = "Select One..."
                    }); 
                    foreach (DataRow dr in dtReg.Rows)
                    {
                        lstRegistration.Add(new RegistrationEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            FullName = dr["PatientName"].ToString()
                        });
                    }

                    lstDoctor.Add(new DoctorEntity()
                    {
                        Id = 0,
                        Name = "Select One..."
                    });
                    foreach (DataRow dr in dtDoctor.Rows)
                    {
                        lstDoctor.Add(new DoctorEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString()
                        });
                    }

                    message = new MessageEntity()
                    {
                        RespCode = "000",
                        RespDesc = "Success",
                        RespMessageType = "MS"
                    };
                }

                return new ResBooking()
                {
                    messageEntity = message,
                    lstRegistration = lstRegistration,
                    lstDoctor = lstDoctor
                };
            }
            catch (Exception ex)
            {
                message = new MessageEntity()
                {
                    RespCode = "999",
                    RespDesc = ex.Message,
                    RespMessageType = "ME"
                };
                return new ResBooking()
                {
                    messageEntity = message
                };
            }
        }

        public MessageEntity Save(BookingEntity booking)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveBooking, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                cmd.Parameters.AddWithValue("@DoctorId", booking.DoctorId);
                cmd.Parameters.AddWithValue("@RegistrationId", booking.RegistrationId);
                //cmd.Parameters.AddWithValue("@Status", booking.Status);
                cmd.Parameters.AddWithValue("@CreatedBy", booking.CreatedBy);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Saving Successfully.";
                message.RespMessageType = CommonResponseMessage.ResSuccessType;

                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespMessageType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public MessageEntity Update(BookingEntity booking)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateBooking, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",booking.Id);
                cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                cmd.Parameters.AddWithValue("@DoctorId", booking.DoctorId);
                cmd.Parameters.AddWithValue("@RegistrationId", booking.RegistrationId);
                cmd.Parameters.AddWithValue("@ModifiedBy", booking.ModifiedBy);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Updating Successfully.";
                message.RespMessageType = CommonResponseMessage.ResSuccessType;

                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespMessageType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public MessageEntity UpdateStatus(int id)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateBookingStatus, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update status Successfully.";
                message.RespMessageType = CommonResponseMessage.ResSuccessType;

                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespMessageType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

        public MessageEntity Delete(int id)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteBooking, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Deleting Successfully.";
                message.RespMessageType = CommonResponseMessage.ResSuccessType;

                return message;
            }
            catch (Exception ex)
            {
                message.RespCode = CommonResponseMessage.ResErrorCode;
                message.RespDesc = ex.Message;
                message.RespMessageType = CommonResponseMessage.ResErrorType;
                return message;
            }
        }

    }
}

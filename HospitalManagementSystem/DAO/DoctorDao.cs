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
    public class DoctorDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResDoctorEntity GetAllDoctor()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllDoctorData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<DoctorEntity> lst = new List<DoctorEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    DoctorEntity doctor = new DoctorEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        SpecialityId = Convert.ToInt32(dr["SpecialityId"]),
                        SpecialityName = dr["SpecialityName"].ToString(),
                        DoctorFees = Convert.ToInt32(dr["DoctorFees"])
                    };
                    lst.Add(doctor);
                }

                return new ResDoctorEntity()
                {
                    lstDoctor = lst
                };
            }
            catch (Exception ex)
            {
                return new ResDoctorEntity()
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

        public ResDoctorEntity GetComboData()
        {
            List<SpecialityEntity> lst = new List<SpecialityEntity>();
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetSpecialityComboData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null)
                {
                    DataTable dtSpeciality = ds.Tables[0];

                    foreach (DataRow dr in dtSpeciality.Rows)
                    {
                        lst.Add(new SpecialityEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            SpecialityName = dr["SpecialityName"].ToString()
                        });
                    }

                    message = new MessageEntity()
                    {
                        RespCode = "000",
                        RespDesc = "Success",
                        RespMessageType = "MS"
                    };
                }

                return new ResDoctorEntity()
                {
                    messageEntity = message,
                    lstSpeciality = lst
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
                return new ResDoctorEntity()
                {
                    messageEntity = message
                };
            }
        }

        public MessageEntity Save(DoctorEntity doctor)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveDoctorData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@SpecialityId", doctor.SpecialityId);
                cmd.Parameters.AddWithValue("@DoctorFees", doctor.DoctorFees);
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

        public MessageEntity Update(DoctorEntity doctor)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateDoctorData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", doctor.Id);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@SpecialityId", doctor.SpecialityId);
                cmd.Parameters.AddWithValue("@DoctorFees", doctor.DoctorFees);
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

        public MessageEntity Delete(int id)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteDoctorData, con);
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

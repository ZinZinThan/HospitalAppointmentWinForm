using HospitalManagementSystem.Common;
using HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DAO
{
    public class SpecialityDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResSpecialityEntity GetAllSpeciality()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllSpeciality, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<SpecialityEntity> lst = new List<SpecialityEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    SpecialityEntity speciality = new SpecialityEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        SpecialityName = dr["SpecialityName"].ToString()
                    };
                    lst.Add(speciality);
                }

                return new ResSpecialityEntity()
                {
                    lstSpeciality = lst
                };
            }
            catch (Exception ex)
            {
                return new ResSpecialityEntity()
                {
                    msgEntity = new MessageEntity()
                    {
                        RespCode = CommonResponseMessage.ResErrorCode,
                        RespDesc = ex.Message,
                        RespMessageType = CommonResponseMessage.ResErrorType
                    }
                };
            }
        }

        public MessageEntity Save(SpecialityEntity speciality)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveSpeciality, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SpecialityName", speciality.SpecialityName);
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

        public MessageEntity Update(SpecialityEntity speciality)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateSpeciality, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", speciality.Id);
                cmd.Parameters.AddWithValue("@SpecialityName", speciality.SpecialityName);
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

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteSpeciality, con);
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

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
    public class MaritalStatusDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResMaritalStatus GetAllMaritalStatus()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllMaritalStatus, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<MaritalStatusEntity> lst = new List<MaritalStatusEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    MaritalStatusEntity status = new MaritalStatusEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString()
                    };
                    lst.Add(status);
                }

                return new ResMaritalStatus()
                {
                    lstMaritalStatus = lst
                };
            }
            catch (Exception ex)
            {
                return new ResMaritalStatus()
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

        public MessageEntity Save(MaritalStatusEntity status)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveMaritalStatus, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", status.Name);
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

        public MessageEntity Update(MaritalStatusEntity status)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateMaritalStatus, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", status.Id);
                cmd.Parameters.AddWithValue("@Name", status.Name);
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

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteMaritalStatus, con);
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

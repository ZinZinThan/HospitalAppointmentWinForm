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
    public class NameTypeDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResNameType GetAllNameType()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllNameType, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<NameTypeEntity> lst = new List<NameTypeEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    NameTypeEntity type = new NameTypeEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        Type = dr["Type"].ToString()
                    };
                    lst.Add(type);
                }

                return new ResNameType()
                {
                    lstNameType = lst
                };
            }
            catch (Exception ex)
            {
                return new ResNameType()
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

        public MessageEntity Save(NameTypeEntity nType)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveNameType, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", nType.Type);
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

        public MessageEntity Update(NameTypeEntity nType)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateNameType, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", nType.Id);
                cmd.Parameters.AddWithValue("@Type", nType.Type);
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

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteNameType, con);
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

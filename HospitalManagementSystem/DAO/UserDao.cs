using HospitalManagementSystem.Common;
using HospitalManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Data;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Drawing;
using System.Windows.Forms;
using static HospitalManagementSystem.Common.CommonFormat;

namespace HospitalManagementSystem.DAO
{
    public class UserDao
    {
        
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResUserEntity Login(UserEntity user)
        {
            con = DbConnector.Connect();
            UserEntity resUser = new UserEntity();
            if (con == null) return null;

            MessageEntity _MessageEntity = new MessageEntity();
            try
            {
                cmd = new SqlCommand(ProcedureConstants.SP_LoginByUserNameAndPassword, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoginName", user.LoginName);
                cmd.Parameters.AddWithValue("@Password", Cryptography.Encrypt(user.Password));
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    resUser.LoginName = row["LoginName"].ToString();
                    resUser.Password = row["Password"].ToString();
                    resUser.RoleId = Convert.ToInt32(row["RoleId"].ToString());
                    _MessageEntity.RespCode = row["RespCode"].ToString();
                    _MessageEntity.RespDesc = row["RespDesc"].ToString();
                    _MessageEntity.RespMessageType = row["RespMessageType"].ToString();
                }
                return new ResUserEntity()
                {
                    messageEntity = _MessageEntity,
                    User = resUser
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ResErrorCode;
                _MessageEntity.RespDesc = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResUserEntity() { messageEntity = _MessageEntity };
            }
        }

        public ResUserEntity GetComboData()
        {
            List<RoleEntity> role = new List<RoleEntity>();
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllUserComboData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt != null)
                {
                    role.Add(new RoleEntity()
                    {
                        Id = 0,
                        RoleName = "Select One..."
                    });
                    foreach (DataRow dr in dt.Rows)
                    {
                        role.Add(new RoleEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            RoleName = dr["RoleName"].ToString()
                        });
                    }

                    message = new MessageEntity()
                    {
                        RespCode = "000",
                        RespDesc = "Success",
                        RespMessageType = "MS"
                    };
                }

                return new ResUserEntity()
                {
                    messageEntity = message,
                    lstRole = role,
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
                return new ResUserEntity()
                {
                    messageEntity = message
                };
            }
        }

        public ResUserEntity GetAllData()
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllUserData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<UserEntity> lst = new List<UserEntity>();
                foreach (DataRow dr in dt.Rows)
                {
                    UserEntity user = new UserEntity()
                    {
                        RowNo = Convert.ToInt32(dr["RowNo"]),
                        Id = Convert.ToInt32(dr["Id"]),
                        Username = dr["Username"].ToString(),
                        LoginName = dr["LoginName"].ToString(),
                        Password = Cryptography.Decrypt(dr["Password"].ToString()),
                        RoleId = Convert.ToInt32(dr["RoleId"]),
                        RoleName = dr["RoleName"].ToString()
                    };
                    lst.Add(user);
                }

                return new ResUserEntity()
                {
                    lstUser = lst
                };
            }
            catch (Exception ex)
            {
                return new ResUserEntity()
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

        public MessageEntity Save(UserEntity user)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_SaveUserData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@LoginName", user.LoginName);
                cmd.Parameters.AddWithValue("@Password", Cryptography.Encrypt(user.Password));
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Create Account Successfully.";
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

        public MessageEntity Update(UserEntity user)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateUserData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@LoginName", user.LoginName);
                cmd.Parameters.AddWithValue("@Password", Cryptography.Encrypt(user.Password));
                cmd.Parameters.AddWithValue("@RoleId", user.RoleId);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Update Account Successfully.";
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

                cmd = new SqlCommand(ProcedureConstants.SP_DeleteUserData, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                message.RespCode = CommonResponseMessage.ResSuccessCode;
                message.RespDesc = "Delete Account Successfully.";
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

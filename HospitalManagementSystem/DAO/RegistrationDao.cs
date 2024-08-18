using HospitalManagementSystem.Common;
using HospitalManagementSystem.Entity;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.DAO
{
    public class RegistrationDao
    {
		SqlConnection con = new SqlConnection();
		SqlCommand cmd = new SqlCommand();
		SqlDataAdapter adapter = new SqlDataAdapter();
        MessageEntity message = new MessageEntity();

        public ResRegistration GetComboData()
        {
			List<NameTypeEntity> lstNameType = new List<NameTypeEntity>();
			List<MaritalStatusEntity> lstMaritalStatus = new List<MaritalStatusEntity>();
			try
			{
				con = DbConnector.Connect();
				if (con is null) return null;

				cmd= new SqlCommand(ProcedureConstants.SP_GetAllRegistrationComboData,con);
				cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
                adapter.Fill(ds);

				if(ds != null)
				{
                    DataTable dtNameType = ds.Tables[0];
                    DataTable dtMarital = ds.Tables[1];

					foreach (DataRow dr in dtNameType.Rows)
					{
						lstNameType.Add(new NameTypeEntity()
						{
							Id = Convert.ToInt32(dr["Id"]),
							Type = dr["Type"].ToString()
						});
					}

                    foreach (DataRow dr in dtMarital.Rows)
                    {
                        lstMaritalStatus.Add(new MaritalStatusEntity()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString()
                        });
                    }

					message = new MessageEntity()
					{
						RespCode = "000",
						RespDesc = "Success",
						RespMessageType="MS"
					};
                }

                return new ResRegistration()
                {
                    msgEntity = message,
                    lstNameType = lstNameType,
                    lstMaritalStatus = lstMaritalStatus
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
                return new ResRegistration()
                {
                    msgEntity = message
                };
            }
        }

        public MessageEntity Save(RegistrationEntity reg)
        {
			try
			{
				con = DbConnector.Connect();
				if(con is null) return null;

				cmd = new SqlCommand(ProcedureConstants.SP_SaveRegistration,con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Name",reg.Name);
				cmd.Parameters.AddWithValue("@Dob", reg.Dob);
				cmd.Parameters.AddWithValue("@PhoneNo", reg.PhoneNo);
				cmd.Parameters.AddWithValue("@FatherName", reg.FatherName);
				cmd.Parameters.AddWithValue("@MaritalStatusId", reg.MaritalStatusId);
				cmd.Parameters.AddWithValue("@Gender", reg.Gender);
				cmd.Parameters.AddWithValue("@NameTypeId", reg.NameTypeId);
				cmd.ExecuteNonQuery();

				message.RespCode = CommonResponseMessage.ResSuccessCode;
				message.RespDesc = "Registration Successfully.";
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

		public ResRegistration GetAllRegistrationData()
		{
			try
			{
                con = DbConnector.Connect();
                if (con is null) return null;

				cmd = new SqlCommand(ProcedureConstants.SP_GetAllRegistrationData,con);
				cmd.CommandType = CommandType.StoredProcedure;
				adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);

                if (dt.Rows.Count == 0) return null;

                List<RegistrationEntity> lst = new List<RegistrationEntity>();
				foreach(DataRow dr in dt.Rows)
				{
					RegistrationEntity reg = new RegistrationEntity()
					{
						RowNo = Convert.ToInt32(dr["RowNo"]),
						Id = Convert.ToInt32(dr["Id"]),
						FullName = dr["FullName"].ToString(),
						Name = dr["Name"].ToString(),
						NameTypeId = Convert.ToInt32(dr["NameTypeId"]),
						Dob = Convert.ToDateTime(dr["Dob"]),
						PhoneNo = dr["PhoneNo"].ToString(),
						FatherName = dr["FatherName"].ToString(),
						Gender = dr["Gender"].ToString(),
						MaritalStatusId = Convert.ToInt32(dr["MaritalStatusId"]),
						MaritalStatus = dr["MaritalStatus"].ToString()
					};
					lst.Add(reg);
				}

				return new ResRegistration() 
				{ 
					lstRegistration=lst
				};
            }
            catch (Exception ex)
			{
				return new ResRegistration()
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

        public MessageEntity Update(RegistrationEntity reg)
        {
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_UpdateRegistration, con);
                cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id",reg.Id);
                cmd.Parameters.AddWithValue("@Name", reg.Name);
                cmd.Parameters.AddWithValue("@Dob", reg.Dob);
                cmd.Parameters.AddWithValue("@PhoneNo", reg.PhoneNo);
                cmd.Parameters.AddWithValue("@FatherName", reg.FatherName);
                cmd.Parameters.AddWithValue("@MaritalStatusId", reg.MaritalStatusId);
                cmd.Parameters.AddWithValue("@Gender", reg.Gender);
                cmd.Parameters.AddWithValue("@NameTypeId", reg.NameTypeId);
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
                cmd.Parameters.AddWithValue("@Id",id);
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

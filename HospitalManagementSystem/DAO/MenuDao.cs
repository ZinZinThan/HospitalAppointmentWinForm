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
    public class MenuDao
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public ResMenuEntity GetAllMenuByRoleId()
        {
            ResMenuEntity resMenu = new ResMenuEntity();
            try
            {
                con = DbConnector.Connect();
                if (con is null) return null;

                cmd = new SqlCommand(ProcedureConstants.SP_GetAllMenuByRoleId, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", CommonFormat.RoleId);
                adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                List<MenuEntity> lst = new List<MenuEntity>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(new MenuEntity()
                    {
                        MenuId = Convert.ToInt32(dr["MenuId"]),
                        MenuName = dr["Menu"].ToString(),
                        Name = dr["Name"].ToString(),
                        IconName = dr["IconName"].ToString(),
                        RoleId = Convert.ToInt32(dr["RoleId"])
                    });
                }
                return new ResMenuEntity()
                {
                    lstMenu = lst,
                };
            }
            catch (Exception ex)
            {
                return new ResMenuEntity()
                {
                    lstMenu = null
                };
            }
        }


    }
}

using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class RoleEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }

    public class ResRoleEntity
    {
        public MessageEntity messageEntity { get; set; }
        public List<RoleEntity> Rows { get; set; }
    }
}

using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class UserEntity
    {
        public int RowNo { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string LoginName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Password { get; set; }
    }

    public class ResUserEntity
    {
        public MessageEntity messageEntity { get; set; }
        public UserEntity User { get; set; }
        public List<RoleEntity> lstRole { get; set; }
        public List<UserEntity> lstUser { get; set; }
    }
}

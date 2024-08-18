using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class MaritalStatusEntity
    {
        public int RowNo { get; set; }  
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ResMaritalStatus
    {
        public MessageEntity msgEntity { get; set; }
        public List<MaritalStatusEntity> lstMaritalStatus { get; set; }
    }
}

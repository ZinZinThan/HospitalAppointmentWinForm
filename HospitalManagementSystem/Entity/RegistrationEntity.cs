using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HospitalManagementSystem.Entity
{
    public class RegistrationEntity
    {
        public int RowNo {  get; set; } 
        public int Id { get; set; }
        public string Name { get; set; }  
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNo { get; set; }
        public string FatherName { get; set; }
        public int MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public int NameTypeId { get; set; }
    }

    public class ResRegistration
    {
        public MessageEntity msgEntity { get; set; }
        public List<RegistrationEntity> lstRegistration { get; set; }
        public List<NameTypeEntity> lstNameType { get; set; }
        public List<MaritalStatusEntity> lstMaritalStatus { get; set; }
    }
}

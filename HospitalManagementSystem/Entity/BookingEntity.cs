using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class BookingEntity
    {
        public int RowNo { get; set; }
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int RegistrationId { get; set; }
        public string PatientName { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set;}
    }

    public class ResBooking
    {
        public MessageEntity messageEntity { get; set; }
        public List<BookingEntity> lstBooking { get; set; }
        public List<RegistrationEntity> lstRegistration { get; set; }
        public List<DoctorEntity> lstDoctor { get; set; }
    }
}

using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Entity
{
    public class SpecialityEntity
    {
        public int RowNo { get; set; }
        public int Id { get; set; }
        public string SpecialityName { get; set; }
    }

    public class ResSpecialityEntity
    {
        public MessageEntity msgEntity { get; set; }
        public List<SpecialityEntity> lstSpeciality { get; set; }
    }
}

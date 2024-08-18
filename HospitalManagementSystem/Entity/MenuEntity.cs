﻿using HospitalManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entity
{
    public class MenuEntity
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Name { get; set; }
        public string IconName { get; set; }
        public int RoleId { get; set; }
    }

    public class ResMenuEntity
    {
        public MessageEntity messageEntity { get; set; }
        public List<MenuEntity> lstMenu { get; set; }
    }
}

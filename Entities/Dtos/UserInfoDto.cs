﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserInfoDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal? Rate { get; set;}

    }
}

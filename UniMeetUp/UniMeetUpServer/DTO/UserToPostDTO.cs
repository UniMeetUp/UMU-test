﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniMeetUpServer.DTO
{
    public class UserToPostDTO
    {
        public String Email { get; set; }

        public String Password { get; set; }

        public String DisplayName { get; set; }
    }
}
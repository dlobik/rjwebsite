﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RjWebsite.Models
{
    public class Chore
    {
        public int ID { get; set; }
        public string CName { get; set; }
        public int CDifficulty { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClassLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Students Students { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPower.Models
{
    public class BusinessTypeFac
    {
        [Key]
        public int Id { get; set; }
        public string busnisstype { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkOrders.Model
{
    public class State
    {
        public int Id { get; set; }
        [StringLength(5)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}

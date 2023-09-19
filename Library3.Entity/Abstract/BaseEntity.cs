﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Abstract
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
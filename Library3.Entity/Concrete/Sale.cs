﻿using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Entity.Concrete
{
    public class Sale : BaseEntity
    {
        public decimal? DiscountRate { get; set; }
        public int? BookId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set;}
        public Book? Book { get; set; }
    }
}

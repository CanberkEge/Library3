﻿using Library3.Entity.Concrete;

namespace Library3.WebMVC.Areas.Admin.Models.DTOs
{
    public class BookSaleViewDTO
    {
        //-----------------------------------------------------------------------
        public int Id { get; set; }
        //-----------------------------------------------------------------------
        public IEnumerable<Book> Books { get; set; }
        //-----------------------------------------------------------------------
        public IEnumerable<Sale> Sales { get; set; }
        //-----------------------------------------------------------------------
        public decimal? DiscountRate { get; set; }
        //-----------------------------------------------------------------------
        public DateTime? StartDate { get; set; }
        //-----------------------------------------------------------------------
        public DateTime? EndDate { get; set; }
        //-----------------------------------------------------------------------
        public string? BookName { get; set; }
        //-----------------------------------------------------------------------
        
        
        public double? Price { get; set; }
        //-----------------------------------------------------------------------
        public Book? Book { get; set; }
        //-----------------------------------------------------------------------
        public string? BookPhotoName { get; set; }
        //-----------------------------------------------------------------------
    }
}

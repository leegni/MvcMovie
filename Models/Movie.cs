﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Display(Name ="Release Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }
        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$"), StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
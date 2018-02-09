using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStoreApplication.Models
{
    public class Album
    {
       
        public string Title { get; set; }
        public Genre Genre { get; set; }
        [Display(Name ="AlbumCover")]
        public string AlbumArtUrl { get; set; }
        [DisplayFormat(DataFormatString="{0:c}")]
        public double Price { get; set; }
    }
}
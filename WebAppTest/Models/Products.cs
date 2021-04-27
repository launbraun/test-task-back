using System;
using System.Collections.Generic;


namespace WebAppTest.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string header { get; set; }
        public string description { get; set; }
        public IList<string> route { get; set; }
        public DateTimeOffset periodStart { get; set; }
        public DateTimeOffset periodEnd { get; set; }
        public double minPrice { get; set; }
        public PhotoCard photoCard { get; set; }
        public IList<PhotoAlbum> photoAlbum { get; set; }
    }

    public class PhotoCard
    {
        public string photo { get; set; }
        public string thumbnail { get; set; }
    }

    public class PhotoAlbum
    {
        public string photo { get; set; }
        public string thumbnail { get; set; }
    }

}



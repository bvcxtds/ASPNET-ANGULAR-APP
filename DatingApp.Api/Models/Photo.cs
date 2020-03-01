using System;

namespace DatingApp.Api.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Url { get; set; }
        public string Decription { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}
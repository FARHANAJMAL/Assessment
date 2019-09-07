using System;
using System.Collections.Generic;

namespace Assessment.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public string Descirption { get; set; }
        public byte[] Image { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Client.Models
{
    public class Member
    {
        [Display(Name ="Id")]
        public int Id { get; set; }
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Display(Name = "Link ảnh")]
        public string Thumb { get; set; }
        [Display(Name = "Nội dung")]
        public string Description { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int Comment_ID { get; set; }
        public string Comment_Writer { get; set; }
        public string Comment_Title { get; set; }
        public string Comment_Content { get; set; }

        public DateTime Comment_Date { get; set; }
        public bool Comment_Status { get;set; }
        public int Blog_ID { get; set; }
        public Blog Blogs { get; set; }
    }
}

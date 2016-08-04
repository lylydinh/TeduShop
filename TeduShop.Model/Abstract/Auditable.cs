﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]//chi ra do dai trong database
        public string CreatedBy { set; get; } 
        public DateTime? UpdatedDate { set; get; } 
        [MaxLength(256)]
        public string UpdatedBy { set; get; } 
        public string MetaKeyworld { set; get; } 
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string DepartmentName { get; set; }



        [Required]
        public string DepatmentMoto { get; set; }

        
        [Required]
        public string DepartmentDescription { get; set; }

        
        public string DepartmentImageUrl { get; set; }

        [NotMapped]
        public HttpPostedFileBase DepartmentImage { get; set; }
    }
}
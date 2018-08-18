﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BHSM.Areas.Admin.Models
{
    public class StaffProfile
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string SecondName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string imageUrl { get; set; }
        [Required]
        public string Gender { get; set; }


        [Required]
        public string Nationality { get; set; }

        [Required]
        public string AcademicRank { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public string Specialization { get; set; }


        [Required]
        public string PersonalStatement { get; set; }



        public Department Department { get; set; }
        public int DepartmentId { get; set; }






    }
}
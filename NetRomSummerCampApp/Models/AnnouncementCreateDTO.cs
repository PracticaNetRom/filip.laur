﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetRomSummerCampApp.Models
{
    public class AnnouncementCreateDTO
    {
        [Required]
        [StringLength(16)]
        public string Phonenumber { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }

        public string Description { get; set; }

        [Required]
        [StringLength(64)]
        public string Title { get; set; }

        public int CategoryId { get; set; }
    }
}
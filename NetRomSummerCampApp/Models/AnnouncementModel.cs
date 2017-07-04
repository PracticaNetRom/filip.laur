﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetRomSummerCampApp.Models
{

    public class AnnouncementRootobject
    {
        public Announcement[] Announcements { get; set; }
    }

    public class Announcement
    {
        public int Id { get; set; }
        public bool Closed { get; set; }
        public string Title { get; set; }
        public string CategoryName { get; set; }
    }



    public class AnnouncementWithDetails
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime PostDate { get; set; }
        public string Phonenumber { get; set; }
        public string Title { get; set; }
        public bool Closed { get; set; }
        public string Description { get; set; }
    }


}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeApp.Models
{
    public class Occasion
    {
        [Key]
        public int OccasionID { get; set; }

        public string OccasionName { get; set; }

        public virtual ICollection<Outfit> Outfits { get; set; }
    }
}
﻿using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse_MySQL.Models
{
    public class Appointments
    {
        public int Id { get; set; }

        [Display(Name = "Sales Person")]
        public string SalesPersonId { get; set; }
        [ForeignKey("SalesPersonId")]
        public virtual ApplicationUser SalesPerson { get; set; }
        public DateTime AppointmentDate { get; set; }

        [NotMapped] 
        public DateTime AppontmentTime { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public bool isComfirmed { get; set; }

    }
}

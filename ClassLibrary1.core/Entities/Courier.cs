﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.core.Entities
{
    [Table("Courier")]
    public class Courier
    {
        [Key]
        public int CourierID { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public int VehicleID { get; set; }
        public int Rating { get; set; }
        public bool Availability { get; set; }
        public string ContactPhone { get; set; }

        public Courier(int courierID, int userID, string fullName, int vehicleID, int rating, bool availability, string contactPhone)
        {
            CourierID = courierID;
            UserID = userID;
            FullName = fullName;
            VehicleID = vehicleID;
            Rating = rating;
            Availability = availability;
            ContactPhone = contactPhone;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaFinalProject.Models
{
    public class Order
    {
        // Properties
        // OrderID
        public Int32 OrderID { get; set; }

        //TODO: implement get for transaction ID/add utility class
        public Int32 ConfirmationID { get; set; }

        public Boolean Complete { get; set; }

        public Decimal Subtotal { get; set; }

        public Decimal TaxAmount { get; set; }

        public Decimal Total { get; set; }

<<<<<<< HEAD

        public bool active { get; set; }

        [Required(ErrorMessage = "CreditCardUsed is required.")]
        public String CreditCardUsed {get; set;}

        [Required(ErrorMessage = "OrderDate is required.")]
=======
>>>>>>> 807ae42298a08f988a93823ec3295b4f202d485a
        public DateTime OrderDate { get; set; }

        // Tickets
        public virtual List<Ticket> Tickets { get; set; }
        // Credit Card
        public virtual CreditCard CreditCard { get; set; }

        //AppUser
        public virtual AppUser AppUser { get; set; }

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }
    }
}
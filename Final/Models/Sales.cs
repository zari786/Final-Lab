using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }
        //public int TyreId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required")]
        public string CustomerName { get; set; }


        public string TransactionDateTime { get; set; }
        public int CashReceived { get; set; }
    }
}
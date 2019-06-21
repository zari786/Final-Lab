using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Tyres
    {
        public Tyres()
        {
            sales = new List<Sales>();
        }

        [Key]
        public int TyreId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Brand is Required")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Enter a valid Brand")]
        public string Brand { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is Required.")]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Size is Required.")]
        [RegularExpression(@"^[0-9]{1,3}/[0-9]{1,2}/[0-9]{1,2}" , ErrorMessage = "Enter a valid size 123/24/68")]
        public string Size { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Condition is Required.")]
        public string Condition { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is Required.")]
        public int Quantity { get; set; }

        public int Purchase_Price { get; set; }
        public int SellingPrice { get; set; }

        public List<Sales> sales { get; set; }
    }
}
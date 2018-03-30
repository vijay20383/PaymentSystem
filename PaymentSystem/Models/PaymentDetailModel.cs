using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaymentSystem.Models
{
    public class PaymentDetailModel
    {
        public int UserId { get; set; }
        [Required]
        public string BSB { get; set; }
        [Required]
        public long AccountNo { get; set; }
        [Required]
        public string AccountName { get; set; }
        //[Required]
        public string Reference { get; set; }
        [Required]
        [Range(0.01,99999999, ErrorMessage = "Amount must be greater than 0.00")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Amount allowed upto two decimal places only.")]
        public decimal Amount { get; set; }
    }
}
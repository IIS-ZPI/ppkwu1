using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NbpApi.Models
{
    public class CurrencyInfo
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DateFromFile { get; set; }

        public string CodeOfCurrency { get; set; }

        public decimal TheValueOfTheExchangeRate { get; set; }
    }
}
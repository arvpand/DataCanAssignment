using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCanAssignment.Models
{
    public class Eur : CurrencyType
    {
        public override decimal ConvertToCad(decimal amount)
        {
            return amount / 0.65m;
        }
        public override string Name
        {
            get
            {
                return "EUR";
            }
        }
    }
}
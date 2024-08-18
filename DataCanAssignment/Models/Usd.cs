using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCanAssignment.Models
{
    public class Usd : CurrencyType
    {
        public override decimal ConvertToCad(decimal amount) => amount / 0.50m;
        public override string Name => "USD";
    }
}
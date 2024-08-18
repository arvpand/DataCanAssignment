using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCanAssignment.Models
{
    public class Cad : CurrencyType
    {
        public override decimal ConvertToCad(decimal amount) => amount;
        public override string Name => "CAD";
    }
}
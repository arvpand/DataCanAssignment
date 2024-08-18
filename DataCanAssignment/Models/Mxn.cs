using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCanAssignment.Models
{
    public class Mxn : CurrencyType
    {
        public override decimal ConvertToCad(decimal amount) => amount / 10.00m;
        public override string Name => "MXN";
    }
}
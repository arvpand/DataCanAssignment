using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataCanAssignment.Models
{
    public abstract class CurrencyType
    {
        public abstract decimal ConvertToCad(decimal amount);
        public abstract string Name { get; }
    }
}
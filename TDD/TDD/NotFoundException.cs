using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("Ca n'existe pas")
        {
        }
    }
}

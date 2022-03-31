using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class IncorrectTriangleExeption : Exception
    {
        public IncorrectTriangleExeption(string message)
        : base(message) { }
    }
}

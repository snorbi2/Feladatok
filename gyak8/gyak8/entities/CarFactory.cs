using gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8.entities
{
    public class CarFactory : IToyFactory
    {
        public Car CreateNew()
        {
            return new Ball();
        }
    }
}

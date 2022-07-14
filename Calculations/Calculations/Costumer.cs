using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Costumer
    {
        public string Name => "Dalmasio";
        public int Age => 25;

        public void UpdateConsumer()
        {
            throw new NotImplementedException();
        }

        public Costumer NewConsumer()
        {
            return new Costumer();
        }
    }
}

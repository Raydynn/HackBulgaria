using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious
{
    public class Car
    {
        public virtual bool isEcoFriendly(bool testing)
        {
            return true;
        }
    }
    public class Audi : Car
    {
        
    }
    public class Bmw : Car
    {
        
    }
    public class Volkswagen : Car
    {
        public override bool isEcoFriendly(bool testing)
        {
            return testing;
        }
    }
    public class Honda : Car
    {
        
    }
    public class Skoda : Car
    {
        
    }
}

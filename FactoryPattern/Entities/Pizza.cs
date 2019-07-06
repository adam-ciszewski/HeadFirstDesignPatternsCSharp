using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Entity
{
    public abstract class Pizza
    {
        public virtual void Prepare()
        {
            throw new NotImplementedException();
        }
        public virtual void Bake()
        {
            throw new NotImplementedException();
        }
        public virtual void Box()
        {
            throw new NotImplementedException();
        }
        public virtual void Cut()
        {
            throw new NotImplementedException();
        }

    }
}

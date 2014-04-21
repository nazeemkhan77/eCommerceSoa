using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceSoa.Exception.Product
{
    public class InvalidProductIdException : ApplicationException
    {
        public InvalidProductIdException(long productId) 
        {

        }
    }
}

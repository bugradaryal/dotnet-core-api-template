using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.DataLayer
{
    public class ObjectListClass<T>
    {
        public int Status { get; set; }
        public List<T>? Data { get; set; }
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Teacher : IEntity
    {
        public int TID { get; set; }
        public string TName { get; set; }
        public string Education { get; set; }
        public int Course { get; set; }
    }
}

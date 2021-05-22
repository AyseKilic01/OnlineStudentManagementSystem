using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Student : IEntity
    {
        public int SID { get; set; }
        public decimal FeesDetail { get; set; }
        public string Name { get; set; }
        public string EducationDetail { get; set; }
        public string PersonelDetail { get; set; }
        public int Course { get; set; }
    }
}

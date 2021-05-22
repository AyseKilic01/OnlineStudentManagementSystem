using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Course : IEntity
    {
        public int CID { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Fees { get; set; }
        public string CName { get; set; }
        public int AdminID { get; set; }
    }
}

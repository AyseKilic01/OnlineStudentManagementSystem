using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : IService<Course>
    {
        private ICourseDAL _dal;

        public CourseManager(ICourseDAL productDal)
        {
            _dal = productDal;
        }

        public List<Course> GetAll()
        {
            return _dal.GetAll();

        }
    }
}

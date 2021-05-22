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
    public class StudentManager : IService<Student>
    {
        private IStudentDAL _dal;

        public StudentManager(IStudentDAL productDal)
        {
            _dal = productDal;
        }

        public List<Student> GetAll()
        {
            return _dal.GetAll();

        }
    }
}

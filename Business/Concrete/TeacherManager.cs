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
   public class TeacherManager : IService<Teacher>
    {
        private ITeacherDAL _dal;

        public TeacherManager(ITeacherDAL productDal)
        {
            _dal = productDal;
        }

        public List<Teacher> GetAll()
        {
            return _dal.GetAll();

        }
    }
}

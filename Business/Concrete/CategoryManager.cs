using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        public IResult Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAllList()
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}

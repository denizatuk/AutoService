using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        [CacheAspect]  //key,value pair
        [PerformanceAspect(5)]
        public IDataResult<List<Product>> GetAllList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }

        public IResult Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

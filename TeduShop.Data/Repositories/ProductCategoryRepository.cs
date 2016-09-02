using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;
namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        //1 danh sach cac category
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>,IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(p => p.Alias == alias);
        }
    }
}
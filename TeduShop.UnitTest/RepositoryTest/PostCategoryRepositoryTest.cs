using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    /// <summary>
    /// Test class gom cac thanh phan la costructurre
    /// </summary>
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        ///Phuong thuc dau tien khoi tao cac tham so doi tuong
        public void Initialize()
        {
            //khoi tao doi tuong
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory ps = new PostCategory();
            ps.Name = "jfjf";
            ps.Alias = "test 1";
            ps.Status = true;
            var resuilt = objRepository.Add(ps);
            unitOfWork.Commit();

            Assert.IsNotNull(resuilt); 
            Assert.AreEqual(1, resuilt.ID);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count());
        }
    }
}
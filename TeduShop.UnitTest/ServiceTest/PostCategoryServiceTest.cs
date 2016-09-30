using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private IPostCategoryService _categoryService;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private List<PostCategory> _lstCategory;

        [TestInitialize]
        ///Phuong thuc dau tien khoi tao cac tham so doi tuong
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _lstCategory = new List<PostCategory>()
            {
                new PostCategory() {ID=1,Name="TEST1",Status=true },
                new PostCategory() {ID=2,Name="TEST2",Status=false },
                new PostCategory() {ID=3,Name="TEST3",Status=true },
            };
        }

        [TestMethod]
        public void PostService_GetAll()
        {
            ///SET UP METHOD
            ///
            _mockRepository.Setup(p => p.GetAll(null)).Returns(_lstCategory);
            ///call action
            ///
            var sesuilt = _categoryService.GetAll() as List<PostCategory>;
            Assert.IsNotNull(sesuilt);
            Assert.AreEqual(3, sesuilt.Count);
        }


        [TestMethod]
        public void PostService_Create()
        {
            PostCategory ps = new PostCategory();
            int id = 1;
            ps.Name = "Name";
            ps.Alias = "test 1";
            ps.Status = true;
            ///setup
            _mockRepository.Setup(p => p.Add(ps)).Returns((PostCategory p)=>{
                p.ID = 1;
                return p;
               
            });
            var resuilt = _categoryService.Add(ps);
            Assert.IsNotNull(resuilt);
            Assert.AreEqual(1, resuilt.ID);
        }
    }
}
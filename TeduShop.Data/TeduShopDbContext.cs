﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TeduShop.Model.Models;

namespace TeduShop.Data
{
    //public class TeduShopDbContext : DbContext
            public class TeduShopDbContext : IdentityDbContext<ApplicationUser>

    {
        //khai bao 1 constructor truyen thang connection string
        public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;//khi load bang cha thi khong tu dong load bang con
        }

        //kghai bao danh sach cac bang
        public DbSet<Footer> Footers { set; get; }

        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlineS { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        public DbSet<Error> Errors { get; set; }//tao moi 1 bang error de log loi 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //tao 1 phuong thuc ghi de
            //xet key cho cac bang user tu sinh tu VS
            modelBuilder.Entity<IdentityUserRole>().HasKey(p=>new { p.UserId ,p.RoleId});
            modelBuilder.Entity<IdentityUserLogin>().HasKey(p => p.UserId); 

        }


        //1 Phuong thuc tao moi chinh no
       //  doi 2 cai dbcon tex:ApplicationDbContext thanh TeduShopDbContext
        public static TeduShopDbContext Create()
        {
            return new TeduShopDbContext();
        }
    }
}
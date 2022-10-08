using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class DepartmentRepository: EfEntityRepositoryBase<Department, ProjectDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

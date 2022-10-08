using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class PersonnelRepository:EfEntityRepositoryBase<Personnel, ProjectDbContext>, IPersonnelRepository
    {
        public PersonnelRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}

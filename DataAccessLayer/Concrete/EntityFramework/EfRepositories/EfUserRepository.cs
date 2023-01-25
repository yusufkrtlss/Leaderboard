using CoreLayer.Data.Concrete;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.EfRepositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User>, IUserDal
    {
        public EfUserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

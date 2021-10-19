using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.DAO
{
   public class UserDao
    {
        HellkitchenDbContext db = null;
        public UserDao()
        {
            db = new HellkitchenDbContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;

        }
        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        //hàm kiểm tra mật khẩu
        public int Login(string userName,string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;

            }
            else
            {
                if (result.Password == passWord)
                    return 1;
                else

                    return -1;

            }
        }
        public bool CheckUsername(string userName)
        {
            return db.Users.Count(x => x.UserName == userName) > 0;

        }
        public bool Checkemai(string email)
        {
            return db.Users.Count(x => x.Email == email) > 0;

        }
    }
}

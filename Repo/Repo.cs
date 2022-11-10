using WebAPI_CodeWay.Models;

namespace WebAPI_CodeWay.Repo
{
    public class Repo:IRepo
    {
        private readonly UserDbContext userDbContext;
        public Repo(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }



        public IEnumerable<UserInfo> GetUsers()
        {
            return userDbContext.UsersDB;
        }
        public int AddUser(UserInfo userInfo)
        {
            userDbContext.UsersDB.Add(userInfo);
            userDbContext.SaveChanges();
            return 0;
        }
        public int UpdateUser(UserInfo userInfo)
        {
            userDbContext.UsersDB.Update(userInfo);
            userDbContext.SaveChanges();
            return 0;
        }
        public int DeleteUser(UserInfo userInfo)
        {
            userDbContext.UsersDB.Remove(userInfo);
            userDbContext.SaveChanges();
            return 0;
        }
    }
}

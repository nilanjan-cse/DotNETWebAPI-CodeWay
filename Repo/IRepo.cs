using WebAPI_CodeWay.Models;

namespace WebAPI_CodeWay.Repo
{
    public interface IRepo
    {
        public IEnumerable<UserInfo> GetUsers();
        public int AddUser(UserInfo userInfo);
        public int UpdateUser(UserInfo userInfo);
        public int DeleteUser(UserInfo userInfo);
    }
}

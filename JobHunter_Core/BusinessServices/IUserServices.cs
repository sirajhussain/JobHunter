using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobHunter.DataModel;
using JobHunter.BusinessEntities;

namespace JobHunter.BusinessServices
{
    /// <summary>
    /// User Service Contract
    /// </summary>
    public interface IUserServices
    {

        UserEntity GetUserById(int userId);
        IEnumerable<UserEntity> GetAllUsers();
        int CreateUser(UserEntity userEntity);
        bool UpdateUser(int userId, UserEntity userEntity);
        bool DeleteUser(int userId);


    }
}

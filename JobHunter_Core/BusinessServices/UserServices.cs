using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.UnitOfWork;
using JobHunter.BusinessEntities;
using AutoMapper;
using JobHunter.DataModel;
using System.Transactions;


namespace JobHunter.BusinessServices
{
    public class UserServices : IUserServices
    {
       private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public UserServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Fetches product details by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public UserEntity GetUserById(int userId)
        {
            var product = _unitOfWork.UserRepository.GetByID(userId);
            if (product != null)
            {
                Mapper.CreateMap<User, UserEntity>();
                var productModel = Mapper.Map<User, UserEntity>(product);
                return productModel;
            }
            return null;
        }

        /// <summary>
        /// Fetches all the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAllUsers()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            if (users.Any())
            {
                Mapper.CreateMap<User, UserEntity>();
                var usersModel = Mapper.Map<List<User>, List<UserEntity>>(users);
                return usersModel;
            }
            return null;
        }

        /// <summary>
        /// Creates a product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int CreateUser(UserEntity userEntity)
        {
            using (var scope = new TransactionScope())
            {
                var user = new User
                {
                    Name = userEntity.Name
                };
                _unitOfWork.UserRepository.Insert(user);
                _unitOfWork.Save();
                scope.Complete();
                return user.ID;
            }
        }

        /// <summary>
        /// Updates a product
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public bool UpdateUser(int userId, UserEntity userEntity)
        {
            var success = false;
            if (userEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var user = _unitOfWork.UserRepository.GetByID(userId);
                    if (user != null)
                    {
                        user.Name = userEntity.Name;
                        _unitOfWork.UserRepository.Update(user);
                        _unitOfWork.Save();
                        //scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Deletes a particular product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public bool DeleteUser(int userId)
        {
            var success = false;
            if (userId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var product = _unitOfWork.UserRepository.GetByID(userId);
                    if (product != null)
                    {

                        _unitOfWork.UserRepository.Delete(product);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zobi.Data;
using Zobi.Domain.Contract;
using Zobi.Domain.Entities;

namespace Zobi.Domain.Services
{
    public class UserService: IUserService
    {
        IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<Users> GetUsers()
        {
            //List<Users> p = new List<Users>;
            var repo = _uow.GetRepository<Users>();
            var pq = repo.Get();
            return pq;
        }
    }
}

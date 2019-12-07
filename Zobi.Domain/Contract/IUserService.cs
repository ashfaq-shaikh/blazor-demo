using System;
using System.Collections.Generic;
using System.Text;
using Zobi.Domain.Entities;

namespace Zobi.Domain.Contract
{
    public interface IUserService
    {
        List<Users> GetUsers();
    }
}

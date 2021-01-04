using BlazorData.Models;
using BlazorData.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorData.UnitsOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }

        Task Commit();
        void Dispose();
    }
}

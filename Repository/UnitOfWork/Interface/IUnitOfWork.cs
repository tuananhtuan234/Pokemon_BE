using Microsoft.EntityFrameworkCore.Storage;
using Repository.Models;
using Repository.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<CartItem> CartItemRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<ChatRequest> ChatRequestRepository { get; }
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        Task<IDbContextTransaction> BeginTransactionAsync();
        Task SaveAsync();
    }
}

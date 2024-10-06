﻿using Microsoft.EntityFrameworkCore.Storage;
using Repository.Models;
using Repository.Repository.Implement;
using Repository.Repository.Interface;
using Repository.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork.Implement
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {     
        private GenericRepository<Customer> _customerRepository;
        private GenericRepository<CartItem> _cartItemRepository;
        private GenericRepository<ChatRequest> _chatRequestRepository;
        private GenericRepository<Category> _categoryRepository;
        private GenericRepository<Order> _orderRepository;
        private PokemonDbContext context = new PokemonDbContext();
        public UnitOfWork(PokemonDbContext context)
        {
            this.context = context;
        }
        private bool disposed = false;

        public IGenericRepository<CartItem> CartItemRepository => _cartItemRepository ?? new GenericRepository<CartItem>(context);

        public IGenericRepository<Category> CategoryRepository => _categoryRepository ?? new GenericRepository<Category>(context);

        public IGenericRepository<Customer> CustomerRepository => _customerRepository ?? new GenericRepository<Customer>(context);

        public IGenericRepository<Order> OrderRepository => _orderRepository ?? new GenericRepository<Order>(context);

        public IGenericRepository<ChatRequest> ChatRequestRepository => _chatRequestRepository ?? new GenericRepository<ChatRequest>(context);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await context.Database.BeginTransactionAsync();
        }
    }
}

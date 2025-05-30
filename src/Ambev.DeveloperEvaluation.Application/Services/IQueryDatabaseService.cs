﻿namespace Ambev.DeveloperEvaluation.Application.Services
{
    public interface IQueryDatabaseService
    {
        Task<IEnumerable<TEntity>> Select<TEntity>(string query, params object[] parameters) where TEntity : class;
        Task<bool> ProductInSaleItems(Guid productId);
        Task<bool> BranchInSales(Guid branchId);
        object[] GetSqlParameters<T>(T parameters);
        Task<bool> UserInSales(Guid userId);
    }
}

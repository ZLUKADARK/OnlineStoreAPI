﻿using OnlineStoreAPI.Domain.Entities;

namespace OnlineStoreAPI.DAL.Interfaces
{
    public interface IItemRepositories : IRepository<Item>
    {
        public Task<ItemProperty> CreateProperty(ItemProperty data);
    }
}
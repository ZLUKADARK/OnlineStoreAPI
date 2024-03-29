﻿using OnlineStoreAPI.Domain.DataTransferObjects;
using OnlineStoreAPI.Domain.DataTransferObjects.ItemCategory;

namespace OnlineStoreAPI.BLL.Interfaces
{
    public interface IItemCategoryServices
    {
        public Task<ResponseDTO<ItemCategoryDTO>> GetAsync(int id);
        public Task<ResponseDTO<IEnumerable<ItemCategoryDTO>>> GetAsync();
        public Task<ResponseDTO<ItemCategoryDTO>> UpdateAsync(UpdateItemCategory data);
        public Task<ResponseDTO<ItemCategoryDTO>> DeleteAsync(int id);
        public Task<ResponseDTO<ItemCategoryDTO>> CreateAsync(ItemCategoryAdd data);
        public Task<ResponseDTO<ItemCategoryDTO>> DeletePropertyAsync(ItemCategoryDeleteProperties data);
        public Task<ResponseDTO<ItemCategoryDTO>> AddPropertyAsync(ItemCategoryAddProperties data);
        public Task<ResponseDTO<ItemCategoryDTO>> UpdatePropertyAsync(ItemCategoryAddProperties data);
    }
}

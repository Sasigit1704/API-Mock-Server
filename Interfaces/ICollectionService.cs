using ApiMockServer.DTOs;
using ApiMockServer.Models;

namespace ApiMockServer.Interfaces
{
    public interface ICollectionService
    {
        Task<List<Collection>> GetAllAsync();

        Task<Collection?> GetByIdAsync(string id);

        Task CreateAsync(CreateCollectionDto dto);

        Task UpdateAsync(string id, UpdateCollectionDto dto);

        Task DeleteAsync(string id);
    }
}
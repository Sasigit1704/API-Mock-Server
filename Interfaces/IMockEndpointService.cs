using ApiMockServer.DTOs;
using ApiMockServer.Models;

namespace ApiMockServer.Interfaces
{
    public interface IMockEndpointService
    {
        Task<List<MockEndpoint>> GetAllAsync();

        Task<MockEndpoint?> GetByIdAsync(string id);

        Task CreateAsync(CreateMockEndpointDto dto);

        Task UpdateAsync(string id, UpdateMockEndpointDto dto);

        Task DeleteAsync(string id);
    }
}
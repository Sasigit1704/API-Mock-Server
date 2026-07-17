using ApiMockServer.DTOs;
using ApiMockServer.Interfaces;
using ApiMockServer.Models;

namespace ApiMockServer.Services
{
    public class MockEndpointService : IMockEndpointService
    {
        private readonly IMockEndpointRepository _repository;

        public MockEndpointService(IMockEndpointRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MockEndpoint>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<MockEndpoint?> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task CreateAsync(CreateMockEndpointDto dto)
        {
            var endpoint = new MockEndpoint
            {
                Name = dto.Name,
                Path = dto.Path.StartsWith("/") ? dto.Path : "/" + dto.Path,
                Method = dto.Method.ToUpper(),
                StatusCode = dto.StatusCode,
                ResponseBody = dto.ResponseBody,
                IsEnabled = dto.IsEnabled
            };

            await _repository.CreateAsync(endpoint);
        }

        public async Task UpdateAsync(string id, UpdateMockEndpointDto dto)
        {
            var endpoint = new MockEndpoint
            {
                Id = id,
                Name = dto.Name,
                Path = dto.Path.StartsWith("/") ? dto.Path : "/" + dto.Path,
                Method = dto.Method.ToUpper(),
                StatusCode = dto.StatusCode,
                ResponseBody = dto.ResponseBody,
                IsEnabled = dto.IsEnabled
            };

            await _repository.UpdateAsync(id, endpoint);
        }

        public async Task DeleteAsync(string id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Abstractions
{
    public interface IBaseCrudService<TAddRequest, TUpdateRequest, TResponse>
    {
        Task<IEnumerable<TResponse>> GetAllAsync();
        Task<TResponse?> GetByIdAsync(Guid id);
        Task<TResponse> CreateAsync(TAddRequest addRequest);
        Task<TResponse?> UpdateAsync(Guid id, TUpdateRequest updateRequest);
        Task<bool> DeleteAsync(Guid id);
    }

}

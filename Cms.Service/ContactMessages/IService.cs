using Cms.Service.Models;
using Cms.Service.Queries;

namespace Cms.Service.ContactMessages;

public interface IService
{
    Task<List<Response.ContactMessageResponse>> GetAllAsync();
    Task<BasePaginationResponse> GetPagedAsync(MessageQuery query);
    Task<int> CountUnreadAsync();
    Task<Response.ContactMessageResponse> CreateAsync(Request.CreateContactMessageRequest request);
    Task<Response.ContactMessageResponse> MarkReadAsync(Guid id);
    Task DeleteAsync(Guid id);
}

namespace Cms.Service.PageContent;

public interface IService
{
    Task<List<Response.PageContentResponse>> GetAllAsync();
    Task UpdateValuesAsync(List<Request.PageContentUpdate> updates);
}

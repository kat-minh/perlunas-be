namespace Cms.Service.ImportantInfor;

public interface IService
{
    Task<List<Response.ImportantInforResponse>> GetAllAsync();
    Task<Response.ImportantInforResponse> GetByIdAsync(Guid id);
    Task<Response.ImportantInforResponse> CreateAsync(Request.CreateImportantInforRequest request);
    Task<Response.ImportantInforResponse> UpdateAsync(Guid id, Request.UpdateImportantInforRequest request);
    Task<string> DeleteAsync(Guid id);
}

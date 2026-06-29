namespace Cms.Service.ComboTiers;

public interface IService
{
    Task<List<Response.ComboTierResponse>> GetAllAsync();
    Task<Response.ComboTierResponse> GetByIdAsync(Guid id);
    Task<Response.ComboTierResponse> CreateAsync(Request.CreateComboTierRequest request);
    Task<Response.ComboTierResponse> UpdateAsync(Guid id, Request.UpdateComboTierRequest request);
    Task DeleteAsync(Guid id);
}

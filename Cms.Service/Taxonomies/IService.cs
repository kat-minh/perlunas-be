using Cms.Repository.Enums;

namespace Cms.Service.Taxonomies;

public interface IService
{
    Task<List<Response.TaxonomyResponse>> GetAllAsync(TaxonomyGroup? group);
    Task<Response.TaxonomyResponse> CreateAsync(Request.CreateTaxonomyRequest request);
    Task<Response.TaxonomyResponse> UpdateAsync(Guid id, Request.UpdateTaxonomyRequest request);
    Task DeleteAsync(Guid id);
}

using Cms.Repository.Enums;

namespace Cms.Service.TourCards;

public interface IService
{
    Task<List<Response.TourCardResponse>> GetAllAsync(TourCardType? type = null);
    Task<Response.TourCardResponse> GetByIdAsync(Guid id, TourCardType? expectedType = null);
    Task<Response.TourCardResponse> CreateAsync(Request.CreateTourCardRequest request);
    Task<Response.TourCardResponse> UpdateAsync(Guid id, Request.UpdateTourCardRequest request, TourCardType? expectedType = null);
    Task DeleteAsync(Guid id, TourCardType? expectedType = null);
}

using Cms.Repository.Enums;
using Cms.Service.Models;

namespace Cms.Service.Form;

public interface IService
{
    Task<BasePaginationResponse> GetAllAsync(int pageIndex, int pageSize, FormType? type);
    Task<Response.FormResponse> GetByKeyAsync(string key);
    Task<string> CreateAdviseAsync(Request.CreateAdviseFormRequest request);
    Task<string> CreateTourAsync(Request.CreateTourFormRequest request);
    Task<string> CreateComboAsync(Request.CreateBookingFormRequest request);
    Task<string> CreateHotelAsync(Request.CreateBookingFormRequest request);
}

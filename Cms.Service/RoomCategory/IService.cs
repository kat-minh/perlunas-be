namespace Cms.Service.RoomCategory;

public interface IService
{
    Task<List<Response.RoomCategoryResponse>> GetAllAsync();
    Task<Response.RoomCategoryResponse> GetByIdAsync(Guid id);
    Task<Response.RoomCategoryResponse> CreateAsync(Request.CreateRoomCategoryRequest request);
    Task<Response.RoomCategoryResponse> UpdateAsync(Guid id, Request.UpdateRoomCategoryRequest request);
    Task<string> DeleteAsync(Guid id);
}

namespace GBSPlans.Application.Interface.Helpers;

public interface IExternalApiService
{
    Task<string> GetPostAsync(int id);
    Task<string> CreatePostAsync(object payload);
}

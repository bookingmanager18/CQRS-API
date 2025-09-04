using GBSPlans.Application.Interface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GBSPlans.Application.UseCases.Helpers;

public class ExternalApiService : IExternalApiService
{
    private readonly HttpClient _httpClient;

    public ExternalApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetPostAsync(int id)
    {
        var response = await _httpClient.GetAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> CreatePostAsync(object payload)
    {
        var response = await _httpClient.PostAsJsonAsync("https://jsonplaceholder.typicode.com/posts", payload);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }
}

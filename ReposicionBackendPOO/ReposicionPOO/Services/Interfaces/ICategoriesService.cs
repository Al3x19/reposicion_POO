using ReposicionPOO.Dtos;

namespace ReposicionPOO.Services.Interfaces
{
    public interface ICategoriesService
    {
        Task<List<CategoriesDto>> GetCategoriesAsync();
        Task<List<CategoriesDto>> GetCategoriesByIdAsync(Guid id);

    } 
}

using ReposicionPOO.Dtos;
using ReposicionPOO.Services.Interfaces;
using Newtonsoft.Json;
using ReposicionPOO.DataBase.Entidades;
namespace ReposicionPOO.Services
{
    public class CategoriesService : ICategoriesService
    {
        public readonly string _JSON_FILE;

        public CategoriesService()
        {
            _JSON_FILE = "SeedData/categories.json";
        }

        public async Task<List<CategoriesDto>> GetCategoriesAsync()
        {
            return await ReadCategoriesFromFileAsync();
        }

        public async Task<CategoriesDto> GetCategoryByIdAsync(Guid id)
        {
            var categories = await ReadCategoriesFromFileAsync();
            CategoriesDto category = categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        Task<List<CategoriesDto>> ICategoriesService.GetCategoriesByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        private async Task<List<CategoriesDto>> ReadCategoriesFromFileAsync()
        {
            if (!File.Exists(_JSON_FILE))
            {
                return new List<CategoriesDto>();
            }

            var json = await File.ReadAllTextAsync(_JSON_FILE);

            var categories = JsonConvert.DeserializeObject<List<CategoryEntity>>(json);

            var dtos = categories.Select(x => new CategoriesDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            return dtos;
        }

        private async Task WriteCategoriesToFileAsync(List<CategoryEntity> categories) 
        {
            var json = JsonConvert.SerializeObject(categories, Formatting.Indented);

            if (File.Exists(_JSON_FILE))
            {
                await File.WriteAllTextAsync(_JSON_FILE, json);
            }

        }
    }
}

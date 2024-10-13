namespace WebApplication1.Modeli
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryDto> GetAll();
        CategoryDto GetById(int id);
        void Add(CategoryDto c);
        void Update(CategoryDto c);
        void Delete(int id);
    }
}

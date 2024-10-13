namespace WebApplication1.Modeli
{
    public interface IProductRepository
    {
        //Task<IEnumerable<ProductDto>> GetAllAsync(); //asinhrono vracanje podataka
        //Task<ProductDto> GetByIdAsync(int id); //vracanje objekta (asinhrono)
        //Task AddAsync(ProductDto p); //dodavanje proizvoda (asinhrono)
        //Task UpdateAsync(ProductDto p); //menjanje proizvoda (asinhrono)
        //Task DeleteAsync(int id); //brisanje proizvoda (asinhrono)


        IEnumerable<ProductDto> GetAll(DateTime? datumOd, DateTime? datumDo);
        IEnumerable<ProductDto> GetProductsByDateRange(DateTime? datumOd, DateTime? datumDo);
        ProductDto GetById(int id);
        void Add(ProductDto p);
        void Update(ProductDto p);
        void Delete(int id);
    }
}

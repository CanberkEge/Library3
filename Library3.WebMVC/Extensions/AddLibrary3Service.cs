using Library3.Business.Abstract;
using Library3.Business.Concrete;
using Library3.DAL.Abstract;
using Library3.DAL.Concrete;

namespace Library3.WebMVC.Extensions
{
    public static class AddLibrary3Service
    {
        public static IServiceCollection AddLibrary3Services(this IServiceCollection services)
        {
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            services.AddScoped<IBookManager, BookManager>();
            services.AddScoped<IBookRepository, BookRepository>();

            services.AddScoped<IPublisherManager, PublisherManager>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();

            services.AddScoped<IReaderManager, ReaderManager>();
            services.AddScoped<IReaderRepository, ReaderRepository>();

            services.AddScoped<IStaffManager, StaffManager>();
            services.AddScoped<IStaffRepository, StaffRepository>();

            services.AddScoped<ISaleManager, SaleManager>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            services.AddScoped<ICartManager, CartManager>();
            services.AddScoped<ICartRepository, CartRepository>();

            return services;
        }

        public static string TurkceKarakterDuzelt(this string str, string v)
        {
            str = str.Replace('ş', 's');
            return str;
        }
    }
}

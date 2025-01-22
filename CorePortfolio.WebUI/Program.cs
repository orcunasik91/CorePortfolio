using CorePortfolio.Business.Abstract;
using CorePortfolio.Business.Concrete;
using CorePortfolio.DataAccess.Abstract;
using CorePortfolio.DataAccess.Concrete.Context;
using CorePortfolio.DataAccess.Concrete.Repositories.EntityFramework;

namespace CorePortfolio.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MyAppContext>();
            builder.Services.AddScoped<IFeatureDal, EfFeatureRepository>();
            builder.Services.AddScoped<IFeatureService, FeatureManager>();
            builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
            builder.Services.AddScoped<IAboutService, AboutManager>();
            builder.Services.AddScoped<IMyServiceDal, EfMyServiceRepository>();
            builder.Services.AddScoped<IMyServiceService, MyServiceManager>();
            builder.Services.AddScoped<ISkillDal, EfSkillRepository>();
            builder.Services.AddScoped<ISkillService, SkillManager>();
            builder.Services.AddScoped<IPortfolioDal, EfPortfolioRepository>();
            builder.Services.AddScoped<IPortfolioService, PortfolioManager>();
            builder.Services.AddScoped<IExperienceDal, EfExperienceRepository>();
            builder.Services.AddScoped<IExperinceService, ExperienceManager>();
            builder.Services.AddScoped<ITestimonialDal, EfTestimonialRepository>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
            builder.Services.AddScoped<IContactDal, EfContactRepository>();
            builder.Services.AddScoped<IContactService, ContactManager>();
            builder.Services.AddScoped<IMessageDal, EfMessageRepository>();
            builder.Services.AddScoped<IMessageService, MessageManager>();
            builder.Services.AddScoped<IToDoListDal, EfToDoListRepository>();
            builder.Services.AddScoped<IToDoListService, ToDoListManager>();
            

            WebApplication app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
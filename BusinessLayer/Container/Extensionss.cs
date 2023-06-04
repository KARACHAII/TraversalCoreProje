using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container
{
    public static class Extensionss
    {
        public static void ContainerDependencies(this IServiceCollection Services)
        {
            Services.AddScoped<ICommentService, CommentManager>();
            Services.AddScoped<ICommentDal, EfCommentDal>();
            Services.AddScoped<IDestinationService, DestinationManager>();
            Services.AddScoped<IDestinationDal, EfDestinationDal>();
            Services.AddScoped<IAppUserService, AppUserManager>();
            Services.AddScoped<IAppUserDal, EfAppUserDal>();
            Services.AddScoped<IReservationService, ReservationManager>();
            Services.AddScoped<IReservationDal, EfReservationDal>();
            Services.AddScoped<IGuideService, GuideManager>();
            Services.AddScoped<IGuideDal, EfGuideDal>();
            Services.AddScoped<IExcelService, ExcelManager>();
            Services.AddScoped<IPdfSerservice, PdfManager>();
            Services.AddScoped<IContactUsService, ContactUsManager>();
            Services.AddScoped<IContactUsDal, EfContactUsDal>();
            Services.AddScoped<IAnnouncementService, AnnouncementManager>();
            Services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }

        public static void CustomerValidator(this IServiceCollection Services)
        {
            Services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
        }
    }
}

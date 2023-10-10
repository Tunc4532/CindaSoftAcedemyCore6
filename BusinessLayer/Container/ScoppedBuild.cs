using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace BusinessLayer.Container
{
    public static class ScoppedBuild
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICourseDal, EfCourseDal>();

            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IEducationDal, EfEducationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IWriterMesssageService, WriterMesssageManager>();
            services.AddScoped<IWriterMesssageDal, EfWriterMesssageDal>();

            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<ILessonDal, EfLessonDal>();

            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAboutDal, EfAboutDal>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatıreDal>();

            services.AddScoped<ITeacherService, TeacherManager>();
            services.AddScoped<ITeacherDal, EfTeacherDal>();

            services.AddScoped<IWelcomeService, WelcomeManager>();
            services.AddScoped<IWelcomeDal, EfWelcomeDal>();

            services.AddScoped<ICommentTeacherService, CommentTeacherManager>();
            services.AddScoped<ICommentTeacherDal, EfCommentTeacherDal>();

            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<IArticleDal, EfArticleDal>();

            services.AddScoped<IPromotionService, PromotionManager>();
            services.AddScoped<IPromotionDal, EfPromotionDal>();

            services.AddScoped<IOnlineLessonService, OnlineLessonManager>();
            services.AddScoped<IOnlineLessonDal, EfOnlineLessonDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EfContactDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUowDal, UowDal>();

        }


    }
}

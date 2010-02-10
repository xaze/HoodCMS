using Ninject.Modules;
using HoodCMS.Data.Concrete;
using HoodCMS.Data.Interfaces;

namespace HoodCMSI.Web.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleRepository>().To<ArticlesRepository>();
            Bind<IOccasionRepository>().To<OccasionRepository>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;

namespace BusinessLayer.DependencyResolver.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();


            builder.RegisterType<DestinationManager>().As<IDestinationService>().SingleInstance();
            builder.RegisterType<EfDestinationDal>().As<IDestinationDal>().SingleInstance();


            builder.RegisterType<AppUserManager>().As<IAppUserService>().SingleInstance();
            builder.RegisterType<EfAppUserDal>().As<IAppUserDal>().SingleInstance();


            builder.RegisterType<ReservationManager>().As<IReservationService>().SingleInstance();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>().SingleInstance();

            builder.RegisterType<GuideManager>().As<IGuideService>().SingleInstance();
            builder.RegisterType<EfGuideDal>().As<IGuideDal>().SingleInstance();
            
            builder.RegisterType<ExcelManager>().As<IExcelService>().SingleInstance();

            builder.RegisterType<PdfManager>().As<IPdfService>().SingleInstance();



        }
    }
}

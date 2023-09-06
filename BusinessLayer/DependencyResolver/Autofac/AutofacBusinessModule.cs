using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BusinessLayer.Abstract;

using BusinessLayer.Abstract.AbstractUow;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ConcreteUow;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

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

            builder.RegisterType<ContactUsManager>().As<IContactUsService>().SingleInstance();
            builder.RegisterType<EfContactUsDal>().As<IContactUsDal>().SingleInstance();  
            
            builder.RegisterType<AnnouncementManager>().As<IAnnouncementService>().SingleInstance();
            builder.RegisterType<EfAnnouncementDal>().As<IAnnouncementDal>().SingleInstance();

            builder.RegisterType<AccountManager>().As<IAccountService>().SingleInstance();
            builder.RegisterType<EfAccountDal>().As<IAccountDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>().SingleInstance();

            builder.RegisterType<UowDal>().As<IUowDal>().SingleInstance();

            //builder.RegisterType<ContactUS>().As<SendMessageDto>().SingleInstance();





        }

       
    }
}

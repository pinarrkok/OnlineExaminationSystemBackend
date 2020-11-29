using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}

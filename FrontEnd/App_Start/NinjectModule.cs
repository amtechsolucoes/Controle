using Domain.Repository;
using Domain.Services;
using Infrastructure;
using Infrastructure.Repository;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FrontEnd.App_Start
{
    public class ControleNinjectModule : NinjectModule
    {
        
        public override void Load()
        {
            //Contexto
            Bind<MyContext>().ToSelf().InRequestScope();

            //Repositorios
          
            //Servicos
          
        }
    }
}
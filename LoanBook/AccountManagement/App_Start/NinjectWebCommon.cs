using AccountManagement.Web.Common;
using Core;
using Core.Commands;
using Core.Events;
using Core.ReadModel;
using Infrastructure.ReadModel;
using Services.Application;
using Services.CommandHandlers;
using Services.EventSubscribers;

[assembly: WebActivator.PreApplicationStartMethod(typeof(AccountManagement.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(AccountManagement.App_Start.NinjectWebCommon), "Stop")]

namespace AccountManagement.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Core.Data;
    using Infrastructure.Data;
    using System.Web.Http;
    using System.Web.Mvc;
    using Infrastructure;
    using Core.Services.Application;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);

            var dependencyResolver = new NinjectDependencyResolver(kernel);
            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;
            DependencyResolver.SetResolver(dependencyResolver);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load<NHibernateNinjectModule>();

            kernel.Bind<ILoanRepository>().To<LoanRepository>();
            kernel.Bind<IMakePaymentService>().To<MakePaymentService>();
            kernel.Bind<IDispatchCommands>().To<ContainerCommandDispatcher>();
            kernel.Bind<IRaiseEvents>().To<ContainerEventPublisher>();

            kernel.Bind<IHandleCommand<ApplyForLoan>>().To<ApplyForLoanCommandHandler>();

            kernel.Bind<ISubscribeToEvent<LoanApplicationAccepted>>().To<LoanApplicationAcceptedSignalClient>();
            kernel.Bind<ISubscribeToEvent<LoanApplicationAccepted>>().To<LoanApplicationAcceptedReadModelSync>();

            kernel.Bind<IRepaymentReadModelRepository>().To<RepaymentReadModelRepository>();
        }        
    }
}

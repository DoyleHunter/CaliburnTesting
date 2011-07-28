using System;
using System.Collections.Generic;
using BackofficeDesktop.ViewModels;
using Caliburn.Micro;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace BackofficeDesktop
{
    public class AppBootstrapper : CastleBootstrapper<ShellViewModel>
	{
	}

    public class CastleBootstrapper<TRootModel> : Bootstrapper<TRootModel>
    {
        private ApplicationContainer _container;

        protected override void Configure()
        {
            _container = new ApplicationContainer();
        }

        protected override object GetInstance(Type service, string key)
        {
            return string.IsNullOrWhiteSpace(key)
                       ? _container.Resolve(service)
                       : _container.Resolve(key, service);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return (IEnumerable<object>)_container.ResolveAll(service);
        }

    }

    public class ApplicationContainer : WindsorContainer
    {
        public ApplicationContainer()
        {
            Register(
                Component.For<IWindowManager>().ImplementedBy<WindowManager>().LifeStyle.Is(LifestyleType.Singleton),
                Component.For<IEventAggregator>().ImplementedBy<EventAggregator>().LifeStyle.Is(LifestyleType.Singleton)
                );
            RegisterViewModels();
        }

        private void RegisterViewModels()
        {
            Register(AllTypes.FromAssembly(GetType().Assembly)
                         .Where(x => x.Name.EndsWith("ViewModel"))
                         .Configure(x => x.LifeStyle.Is(LifestyleType.Transient)));
        }
    }
}

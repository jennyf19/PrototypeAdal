using System;
using System.Collections.Generic;
using Ninject;
using System.Web.Mvc;
using System.Linq;
using Moq;
using PrototypeAdal.Domain.Abstract;
using PrototypeAdal.Domain.Entities;

namespace PrototypeAdal.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IReleaseRequestRepository> mock = new Mock<IReleaseRequestRepository>();
            mock.Setup(m => m.ReleaseRequests).Returns(new List<ReleaseRequest>
            {
                new ReleaseRequest
                {
                    ProductId = 1,
                    Product = "Adal-v3",
                    Branch = "Master",
                    VersionNumber = "v1.00.00",
                    ReleaseNotes = "Cats are amazing"
                },
                new ReleaseRequest
                {
                    ProductId = +1,
                    Product = "Adal-ActiveDirectory",
                    Branch = "Master",
                    VersionNumber = "v1.00.00",
                    ReleaseNotes = "Cats are cool"
                }
            });

            _kernel.Bind<IReleaseRequestRepository>().ToConstant(mock.Object);
        }
    }
}
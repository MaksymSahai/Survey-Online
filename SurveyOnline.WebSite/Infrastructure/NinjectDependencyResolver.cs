using Ninject;
using SurveyOnline.DAL.Interfaces;
using SurveyOnline.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SurveyOnline.DAL.Infrastructure
{
    /// <summary>
    /// Dependency resolver implementation for ninject.
    /// </summary>
    public class NinjectDependencyResolver : IDependencyResolver
    {
        /// <summary>
        /// The ninject kernel.
        /// </summary>
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Mock<ISurveyRepository> mock = new Mock<ISurveyRepository>();
            //mock.Setup(m => m.Surveys).Returns(new List<Survey> {
            //    new Survey { SurveyName = "Test Survey 1 for customer 1", SurveyDescription = "1 Some test description for survey. Lorem Ipsum 1", UserId = 1},
            //    new Survey { SurveyName = "Test Survey 2 for customer 2", SurveyDescription = "2 Some test description for survey. Lorem Ipsum 2", UserId = 2},
            //    new Survey { SurveyName = "Test Survey 3 for customer 3", SurveyDescription = "3 Some test description for survey. Lorem Ipsum 3", UserId = 1},
            //    new Survey { SurveyName = "Test Survey 4 for customer 4", SurveyDescription = "4 Some test description for survey. Lorem Ipsum 4", UserId = 2},
            //    new Survey { SurveyName = "Test Survey 5 for customer 5", SurveyDescription = "5 Some test description for survey. Lorem Ipsum 5", UserId = 1},
            //    new Survey { SurveyName = "Test Survey 6 for customer 6", SurveyDescription = "6 Some test description for survey. Lorem Ipsum 6", UserId = 2},
            //    new Survey { SurveyName = "Test Survey 7 for customer 7", SurveyDescription = "7 Some test description for survey. Lorem Ipsum 7", UserId = 1},
            //    new Survey { SurveyName = "Test Survey 8 for customer 8", SurveyDescription = "8 Some test description for survey. Lorem Ipsum 8", UserId = 2},
            //    new Survey { SurveyName = "Test Survey 9 for customer 9", SurveyDescription = "9 Some test description for survey. Lorem Ipsum 9", UserId = 1},
            //    new Survey { SurveyName = "Test Survey 10 for customer 10", SurveyDescription = "10 Some test description for survey. Lorem Ipsum 10", UserId = 2}
            //});
            //kernel.Bind<ISurveyRepository>().ToConstant(mock.Object);

            kernel.Bind<ISurveyRepository>().To<SurveyRepository>();
        }
    }
}

using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Lifetime;

namespace WebApplication1
{
    public class Bootstrapper
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType(typeof(IAccessPolicyService<>), typeof(AccessPolicyService<>), new TransientLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
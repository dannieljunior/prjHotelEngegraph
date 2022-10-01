using Ninject;
using Ninject.Modules;

namespace Hotel.Comum.IOC
{
    public class Kernel
    {
        private static StandardKernel _kernel;

        public static void Initialize(NinjectModule[] modules)
        {
            _kernel = new StandardKernel(modules);
        }

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }

    }
}

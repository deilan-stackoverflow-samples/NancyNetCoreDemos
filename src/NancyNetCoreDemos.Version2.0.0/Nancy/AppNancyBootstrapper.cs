using Microsoft.AspNetCore.Hosting;
using Nancy;
using Nancy.Conventions;

namespace NancyNetCoreDemos.Version2._0._0.Nancy
{
    public class AppNancyBootstrapper : DefaultNancyBootstrapper
    {
        public AppNancyBootstrapper(IHostingEnvironment environment)
        {
            RootPathProvider = new AppRootPathProvider(environment);
        }
        protected override void ConfigureConventions(NancyConventions conventions)
        {
            base.ConfigureConventions(conventions);

            conventions.StaticContentsConventions.AddDirectory("css");
            conventions.StaticContentsConventions.AddDirectory("js");
            conventions.StaticContentsConventions.AddDirectory("fonts");
            conventions.StaticContentsConventions.AddDirectory("images");
            conventions.StaticContentsConventions.AddDirectory("lib");
        }

        protected override IRootPathProvider RootPathProvider { get; }
    }
}
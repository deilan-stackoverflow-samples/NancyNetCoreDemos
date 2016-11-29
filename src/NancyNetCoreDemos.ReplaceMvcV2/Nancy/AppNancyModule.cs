using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace NancyNetCoreDemos.ReplaceMvcV2.Nancy
{
public class AppNancyModule : NancyModule
{
    public AppNancyModule()
    {
        Get("/", _ => View["index"]);
        Get("/{fileName}", parameters => View[parameters.fileName]);
    }
}
}

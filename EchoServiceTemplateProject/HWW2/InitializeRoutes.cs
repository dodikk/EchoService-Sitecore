using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWW2
{
  using System.Web.Http;
  using System.Web.Routing;
  using Sitecore.Pipelines;

  public class InitializeRoutes : Sitecore.Mvc.Pipelines.Loader.InitializeRoutes
  {
    protected override void RegisterRoutes(RouteCollection routes, PipelineArgs args)
    {
      routes.MapHttpRoute("hwroute", "hw/echo", new
      {
        controller = "Echo",
        action = "Get"/*,
        id = RouteParameter.Optional*/
      });
    }
  }
}
using System;
using Funq;
using ServiceStack.WebHost.Endpoints;

namespace fastcgiserviceinterface
{
	public class AppHost : AppHostBase
	{
		//Tell Service Stack the name of your application and where to find your web services
		public AppHost() : base("Mono FastCGI API", typeof(HelloService).Assembly) { }

		public override void Configure(Container container)
		{
		}
	}
}


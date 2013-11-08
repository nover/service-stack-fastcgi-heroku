using System;
using ServiceStack.ServiceInterface;
using fastcgimodel;

namespace fastcgiserviceinterface
{
	public class HelloService : Service
	{
		public object Any(Hello request)
		{
			return new
			{
				Name = request.Name
			};
		}
	}
}


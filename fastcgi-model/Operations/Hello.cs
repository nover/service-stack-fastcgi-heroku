using System;
using ServiceStack.ServiceHost;

namespace fastcgimodel
{
	[Route("/hello/{Name}", "GET")]
	public class Hello
	{
		public string Name { get; set; }
	}
}


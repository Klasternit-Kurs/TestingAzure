using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishTest.Server
{
	public class TestHub : Hub
	{
		public async Task TestMetoda()
		{
			await Clients.Caller.SendAsync("KlijentTest");
		}
	}
}

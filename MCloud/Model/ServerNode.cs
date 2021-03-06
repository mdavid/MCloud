
using System;
using System.Net;
using System.Collections.Generic;
using ProviderModel = MCloud.Provider.Model;
using MCloud.Provider.Model;

namespace MCloud.Cluster.Model
{

	/// <summary>
	/// A ServerNode represents a server that can be accessed by SSH.  It is not neccasirliy 
	/// in a managed cloud provider so operations like Destroy will not work on it.
	/// You can use these nodes for deployment and rebooting though.
	/// </summary>
    public class ServerNode : ProviderModel.Node
	{
		internal ServerNode (string id, string name, NodeState state, List<IPAddress> public_ips,
				List<IPAddress> private_ips, NodeDriver driver) : base (id, name, state, public_ips, private_ips, driver)
		{
		}
	}
}

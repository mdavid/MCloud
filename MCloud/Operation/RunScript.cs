

using System;
using System.IO;

using Tamir.SharpSsh;
using MCloud.Provider.Model;

namespace MCloud.Operation
{

	public class RunScript : PutFile {

		public RunScript (string local) : base (local)
		{
		}

		public RunScript (string local, string remote_dir) : base (local, remote_dir)
		{
		}

        protected override void RunImpl(Node node, NodeAuth auth)
		{			
			string host = node.PublicIPs [0].ToString ();

			string remote = String.Concat (RemoteDirectory, FilePath);

			PutFile (host, auth, FilePath, remote);
			RunCommand ("chmod 775 " + remote, host, auth);
			RunCommand (remote, host, auth);
		}
	}
}



using System;

namespace MCloud.Operation
{
	public class CreateUser : RunCommand
	{
		public CreateUser (string username) : base ("useradd -h " + username)
		{
			if (username == null)
				throw new ArgumentNullException ("username");
		}
	}
}

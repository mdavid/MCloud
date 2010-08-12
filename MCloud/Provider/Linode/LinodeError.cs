

using System;
using MCloud.Provider.Model;

namespace MCloud.Provider.Linode
{

	public class LinodeError {

		public LinodeError (string message, int code)
		{
			Message = message;
			Code = code;
		}

		public string Message {
			get;
			set;
		}

		public int Code {
			get;
			set;
		}
	}
}


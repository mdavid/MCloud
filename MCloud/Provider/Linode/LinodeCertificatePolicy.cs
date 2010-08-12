
using System.Net;
using System.Security.Cryptography.X509Certificates;
using MCloud.Provider.Model;

namespace MCloud.Provider.Linode
{

	public class LinodeCertificatePolicy : ICertificatePolicy {

		public bool CheckValidationResult (ServicePoint sp, X509Certificate certificate, WebRequest request, int error)
		{
			return true;
		}
	}
}


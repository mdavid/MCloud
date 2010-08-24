using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Web;

namespace GoGrid
{
  // This local class is required for the HTTPS calls to work
  class MyCertificatePolicy : ICertificatePolicy
  {
    public bool CheckValidationResult(ServicePoint srvp, X509Certificate cert, WebRequest req, int problem)
    {
      return true;
    }
  }

  class GoGridClient
  {
    string server = "https://api.gogrid.com/api";
    string api_key = "YOUR API KEY";
    string secret = "YOUR SHARED SECRET";

    // Construct a GoGrid API Request based on the method and params arguments
    public string getAPIRequestURL(string _method, System.Collections.Hashtable _params)
    {
      // Start constructing the request URL, starting with the server and method
      string url = server + "/" + _method + "?api_key=" + api_key + "&v=1.0" + "&sig=" + getSignature(api_key, secret);
      
      // Append the params to the request URL, encoding the values
      if (_params != null)
      {
          foreach (System.Collections.DictionaryEntry d in _params)
          {                    
              url += "&" + d.Key + "=" + HttpUtility.UrlEncode(d.Value.ToString());
          }
      }
      return url;
    }

    // Generate the request signature
    public string getSignature(string _api_key, string _secret)
    {
        int epoch = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        return MD5(_api_key + _secret + epoch);
    }

    // Send an API request
    public string sendAPIRequest(string url)
    {
      // used to build entire input
      StringBuilder sb = new StringBuilder();

      // used on each read operation
      byte[] buf = new byte[8192];

      // prepare the web page we will be asking for

      HttpWebRequest request = null;
      HttpWebResponse response = null;
      try
      {
        ServicePointManager.CertificatePolicy = (ICertificatePolicy)new MyCertificatePolicy();
        request = (HttpWebRequest)
            WebRequest.Create(url);

        // execute the request
        response = (HttpWebResponse)
               request.GetResponse();

        // we will read data via the response stream
        Stream resStream = response.GetResponseStream();

        string tempString = null;
        int count = 0;

        do
        {
          // fill the buffer with data
          count = resStream.Read(buf, 0, buf.Length);

          // make sure we read some data
          if (count != 0)
          {
            // translate from bytes to ASCII text
            tempString = Encoding.ASCII.GetString(buf, 0, count);

            // continue building the string
            sb.Append(tempString);
          }
        }
        while (count > 0); // any more data to read?
      }
      catch (Exception e)
      {
        sb.AppendLine(e.Message);
      }

      // return the string
      return sb.ToString();

    }

    // Code to generate a PHP-like MD5 hash
    public string MD5(string input)
    {
      System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
      byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
      bs = x.ComputeHash(bs);
      System.Text.StringBuilder s = new System.Text.StringBuilder();
      foreach (byte b in bs)
      {
        s.Append(b.ToString("x2").ToLower());
      }
      string password = s.ToString();
      return password;
    }
  }

  class GoGridExample
  {
    static void Main(string[] args)
    {
      // Instantiate a GoGridClient object
      GoGridClient grid = new GoGridClient();

      // List the servers in the grid
      string apiurl = grid.getAPIRequestURL("grid/server/list", null);
      Console.WriteLine(apiurl);
      Console.WriteLine(grid.sendAPIRequest(apiurl));

      // Get particular server info

      System.Collections.Hashtable parameters = new System.Collections.Hashtable();
      parameters.Add("name", "Test Server");
      parameters.Add("format", "json");

      apiurl = grid.getAPIRequestURL("grid/server/get", parameters);
      Console.WriteLine(apiurl);
      Console.WriteLine(grid.sendAPIRequest(apiurl));

      Console.Read();
    }
  }
}
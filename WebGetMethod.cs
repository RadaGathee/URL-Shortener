using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace urlShortener
{
	internal class WebGetMethod
	{
		public string Get(string URL)
		{
			string jsonString = "";
			WebRequest request = WebRequest.Create(URL);
			request.Method = "GET";
			request.ContentType = "application/x-www-form-urlencoded";
			using (var response = request.GetResponse())
			{
				using (var reader = new StreamReader(response.GetResponseStream()))
				{
					jsonString = reader.ReadToEnd();
				}
			}

			return jsonString;
		}
	}
}

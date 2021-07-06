using Newtonsoft.Json;

using RestSharp;

namespace ProjetoGPS_Site
{
	public class SiteCode
	{
		public string ApiEndpoint = "https://papi-testapp2.herokuapp.com/api/";
		//public string ApiEndpoint = "https://localhost:44387/api/";



		public class Placeholders
		{
			public string Placeholder { get; set; }
			public string Value { get; set; }
		}



		public T GET<T>(string url)
		{
			RestClient client = new RestClient(ApiEndpoint + url);
			client.Timeout = -1;
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = client.Execute(request);
			return JsonConvert.DeserializeObject<T>(response.Content);
		}
	}
}

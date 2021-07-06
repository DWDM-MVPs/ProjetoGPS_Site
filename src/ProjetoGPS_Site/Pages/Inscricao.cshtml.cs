using Microsoft.AspNetCore.Mvc.RazorPages;

using Newtonsoft.Json;

using RestSharp;

namespace ProjetoGPS_Site.Pages
{
	public class IncricaoModel : PageModel
	{
		//public string ApiEndpoint = "https://papi-testapp2.herokuapp.com/api/";
		public string ApiEndpoint = "https://localhost:44387/api/";

		public class Application
		{
			public string Name;
			public string Surname;
			public string Email;
			public string City;
			public string Message;
			public int State = 0;
			public int Type;
		}

		public void OnPostSendMessage()
		{
			Application app = new Application();
			app.Name = this.Request.Form["name"];
			app.Surname = this.Request.Form["surname"];
			app.Email = this.Request.Form["email"];
			app.City = this.Request.Form["city"];
			app.Message = this.Request.Form["message"];

			string type = this.Request.Form["selection"];
			if (type == "signup")
			{
				app.Type = 0;
			}
			else if (type == "message")
			{
				app.Type = 1;
			}

			this.POST(app);



			this.Response.Redirect("/MensagemEnviada");
		}

		private void POST(Application app)
		{
			RestClient client = new RestClient(ApiEndpoint + "applications");
			client.Timeout = -1;
			RestRequest request = new RestRequest(Method.POST);
			request.AddHeader("Content-Type", "application/json");
			string body = JsonConvert.SerializeObject(app);
			request.AddParameter("application/json", body, ParameterType.RequestBody);
			IRestResponse res = client.Execute(request);
		}
	}
}

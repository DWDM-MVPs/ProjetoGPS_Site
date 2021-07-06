using Microsoft.AspNetCore.Mvc.RazorPages;

using static ProjetoGPS_Site.SiteCode;

namespace ProjetoGPS_Site.Pages
{
	public class ContactosModel : PageModel
	{
		public string cIpsEmail;
		public string cIpsTel;
		public string cIpsWeb;
		public string cIpvEmail;
		public string cIpvTel;
		public string cIpvWeb;
		public string cIplEmail;
		public string cIplTel;
		public string cIplWeb;

		public ContactosModel()
		{
			SiteCode c = new SiteCode();

			cIpsEmail = c.GET<Placeholders>("placeholders/ContactosIPSEmail").Value;
			cIpsEmail = cIpsEmail.Replace("\n", "<br />");
			cIpsTel = c.GET<Placeholders>("placeholders/ContactosIPSTelefone").Value;
			cIpsTel = cIpsTel.Replace("\n", "<br />");
			cIpsWeb = c.GET<Placeholders>("placeholders/ContactosIPSWebite").Value;
			cIpsWeb = cIpsTel.Replace("\n", "<br />");

			cIpvEmail = c.GET<Placeholders>("placeholders/ContactosIPVEmail").Value;
			cIpvEmail = cIpvEmail.Replace("\n", "<br />");
			cIpvTel = c.GET<Placeholders>("placeholders/ContactosIPVTelefone").Value;
			cIpvTel = cIpvTel.Replace("\n", "<br />");
			cIpvWeb = c.GET<Placeholders>("placeholders/ContactosIPVWebite").Value;
			cIpvWeb = cIpsTel.Replace("\n", "<br />");

			cIplEmail = c.GET<Placeholders>("placeholders/ContactosIPLEmail").Value;
			cIplEmail = cIplEmail.Replace("\n", "<br />");
			cIplTel = c.GET<Placeholders>("placeholders/ContactosIPLTelefone").Value;
			cIplTel = cIplTel.Replace("\n", "<br />");
			cIplWeb = c.GET<Placeholders>("placeholders/ContactosIPLWebite").Value;
			cIplWeb = cIpsTel.Replace("\n", "<br />");
		}
	}
}

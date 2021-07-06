using Microsoft.AspNetCore.Mvc.RazorPages;

using static ProjetoGPS_Site.SiteCode;

namespace ProjetoGPS_Site.Pages
{
	public class SobreModel : PageModel
	{
		public string sobre;

		public SobreModel()
		{
			SiteCode c = new SiteCode();

			sobre = c.GET<Placeholders>("placeholders/About").Value;
			sobre = sobre.Replace("\n", "<br />");
		}
	}
}

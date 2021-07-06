using Microsoft.AspNetCore.Mvc.RazorPages;

using static ProjetoGPS_Site.SiteCode;

namespace ProjetoGPS_Site.Pages
{
	public class IndexModel : PageModel
	{
		public string iAbout;
		public string iWhere;
		public string iWhy;

		public IndexModel()
		{
			SiteCode c = new SiteCode();

			iAbout = c.GET<Placeholders>("placeholders/IndexAbout").Value;
			iAbout = iAbout.Replace("\n", "<br />");
			iWhere = c.GET<Placeholders>("placeholders/IndexWhere").Value;
			iWhere = iWhere.Replace("\n", "<br />");
			iWhy = c.GET<Placeholders>("placeholders/IndexWhy").Value;
			iWhy = iWhy.Replace("\n", "<br />");
		}
	}
}

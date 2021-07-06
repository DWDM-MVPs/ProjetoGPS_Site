using Microsoft.AspNetCore.Mvc.RazorPages;

using static ProjetoGPS_Site.SiteCode;

namespace ProjetoGPS_Site.Pages
{
	public class TestemunhoModel : PageModel
	{
		public string t1n;
		public string t1d;
		public string t2n;
		public string t2d;
		public string t3n;
		public string t3d;

		public TestemunhoModel()
		{
			SiteCode c = new SiteCode();

			t1n = c.GET<Placeholders>("placeholders/Testemunho1Nome").Value;
			t1n = t1n.Replace("\n", "<br />");
			t1d = c.GET<Placeholders>("placeholders/Testemunho1Descricao").Value;
			t1d = t1d.Replace("\n", "<br />");

			t2n = c.GET<Placeholders>("placeholders/Testemunho2Nome").Value;
			t2n = t2n.Replace("\n", "<br />");
			t2d = c.GET<Placeholders>("placeholders/Testemunho2Descricao").Value;
			t2d = t2d.Replace("\n", "<br />");

			t3n = c.GET<Placeholders>("placeholders/Testemunho3Nome").Value;
			t3n = t3n.Replace("\n", "<br />");
			t3d = c.GET<Placeholders>("placeholders/Testemunho3Descricao").Value;
			t3d = t3d.Replace("\n", "<br />");
		}
	}
}

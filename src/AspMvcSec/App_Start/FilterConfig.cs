using System.Web.Mvc;
using NWebsec.Mvc.HttpHeaders;
using NWebsec.Mvc.HttpHeaders.Csp;

namespace AspMvcSec
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());

      #region round1
      filters.Add(new CspAttribute() );
      filters.Add(new CspScriptSrcAttribute()
      {
        CustomSources = "localhost:* ws://localhost:* code.jquery.com:*",
        UnsafeInline = true
      });
      //filters.Add(new CspReportUriAttribute(){ ReportUris  = "http://localhost:50297/Report" });

      #endregion

      #region round2

      #endregion

      #region round3

      // XFrameOptions
      // filters.Add(new XFrameOptionsAttribute() { Policy = XFrameOptionsPolicy.Deny });

      #endregion

    }
  }
}

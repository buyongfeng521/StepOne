using Step.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Web.Mvc
{
    public static class HtmlHelperExtensions
    {
         public static MvcHtmlString CreatPageLiTag(this UrlHelper urlHelper,
                                                   BasePageModel pageModel,
                                                   int index,
                                                   bool isCurrentIndex = false,
                                                   bool isDisable = true,
                                                   string content = "")
        {

            string url = urlHelper.Action(pageModel.ActionName, new { searchkey = pageModel.SearchKeyWord, index = index });
            //string url = urlHelper.Action("BetterAsper", new { searchkey = pageModel.SearchKeyWord, index = index });
            string activeClass = !isCurrentIndex ? string.Empty : "class='active'";
            string disableClass = isDisable ? string.Empty : "class='disabled'";
            url = isDisable ? "href='" + url + "'" : string.Empty;
            string contentString = string.IsNullOrEmpty(content) ? index.ToString() : content;

            return new MvcHtmlString("<li " + activeClass + disableClass + "><a " + url + ">" + contentString + "</a></li>");
        }

    }
}

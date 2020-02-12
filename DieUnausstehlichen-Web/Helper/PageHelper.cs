using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DieUnausstehlichen_Web.Helper
{
    public static class PageHelper
    {
        public class NavbarItem
        {
            public NavbarItem(string action, string controller, string displayName)
            {
                Controller = controller;
                Action = action;
                DisplayName = displayName;
            }

            public string Controller { get; }
            public string Action { get; }
            public string DisplayName { get; }
        }
        public static IHtmlContent NavbarLinks(this IHtmlHelper helper, IEnumerable<NavbarItem> items)
        {
            IHtmlContentBuilder builder = new HtmlContentBuilder();
            var url = new UrlHelperFactory().GetUrlHelper(helper.ViewContext);
            
            foreach (var item in items)
            {
                var a = new TagBuilder("a");
                var li = new TagBuilder("li");
                li.AddCssClass("navbar-item");
                if (IsOnPage(helper.ViewContext, item.Action, item.Controller))
                {
                    li.AddCssClass("navbar-item-current");
                }
                li.InnerHtml.Append(item.DisplayName);
                a.MergeAttribute("href", url.Action(item.Action, item.Controller));
                a.InnerHtml.AppendHtml(li);
                builder.AppendHtml(a);
            }

            return builder;
        }

        private static bool IsOnPage(this ActionContext viewContext, string action, string controller)
        {
            return viewContext.RouteData.Values["action"].Equals(action) &&
                   viewContext.RouteData.Values["controller"].Equals(controller);
        }
    }
}
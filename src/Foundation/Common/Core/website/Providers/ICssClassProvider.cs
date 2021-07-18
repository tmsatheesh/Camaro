using System.Collections.Generic;
using Sitecore.Mvc.Presentation;

namespace Camaro.Foundation.Common.Core.Providers
{
    public interface ICssClassProvider
    {
        List<string> GetCssClasses(string rawValue);
        string GetInlineCssClasses(DynamicPlaceholderRenderContext context, string param);
        string GetCssClass(string pathOrId);
    }
}
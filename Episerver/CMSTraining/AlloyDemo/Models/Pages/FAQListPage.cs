using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Collections.Generic;
namespace AlloyDemo.Models.Pages
{
    [ContentType(
        DisplayName = "FAQ List",
        GroupName = Global.GroupNames.Specialized,
        Description = "Use this page for a list of FAQs entered by visitors, answered by editors.")]
    [SiteImageUrl]
    [AvailableContentTypes(Include = new[] { typeof(FAQItemPage) }, IncludeOn = new[] { typeof(StartPage) })]
    public class FAQListPage : SitePageData
    {
        // having an ignored property avoids needing a view model
        // this property will not be stored in CMS so it does not
        // need to be virtual
        [Ignore]
        public IEnumerable<FAQItemPage> FAQItems { get; set; }
    }
}
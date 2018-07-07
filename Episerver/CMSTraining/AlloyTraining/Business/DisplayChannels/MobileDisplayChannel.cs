using EPiServer.Framework.Web;
using EPiServer.Web;
using System.Web;

namespace AlloyTraining.Business.DisplayChannels
{
    public class MobileDisplayChannel : DisplayChannel
    {
        // C# 6.0 syntax for a read-only property
        public override string ChannelName => RenderingTags.Mobile;
        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }
    }
}
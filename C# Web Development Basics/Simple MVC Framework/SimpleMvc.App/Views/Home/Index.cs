using SimpleMvc.Framework.Interfaces;

namespace SimpleMvc.App.Views.Home
{
    public class Index : IRenderable
    {
        public string Render()
        {
            return "<h1>HI</h1>";
        }
    }
}

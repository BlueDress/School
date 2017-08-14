

namespace Drawing_Tool
{
    public class CorDraw
    {
        private Quadrangle quadrangle;

        public CorDraw(Quadrangle quadrangle)
        {
            this.quadrangle = quadrangle;
        }

        public void Draw()
        {
            this.quadrangle.Draw();
        }
    }
}

using System;
using System.Text;

namespace Graphics3D
{
	public class Segment3D: WireframeObject3D
	{
		private double _lineWidth;

		public Segment3D (Colorspace colorspace, double lineWidth) : base(colorspace)
		{
			_lineWidth = lineWidth;
		}

		public override string GetName ()
		{
			return "Segment3D";
		}

		public override double GetLineWidth()
		{
			return _lineWidth;
		}

        //
        public override bool accept(Renderer renderer)
        {
            return renderer.draw(this);
        }
        public override bool canAcceptr(Renderer rend)
        {
            return rend.canDraw(this);
        }
    }
}


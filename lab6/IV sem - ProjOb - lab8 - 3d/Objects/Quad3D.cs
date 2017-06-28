using System;
using System.Text;

namespace Graphics3D
{
	public class Quad3D: FilledObject3D
	{
		private double _transparenceyLevel;

		public Quad3D (Colorspace colorspace, double transparencyLevel) : base(colorspace)
		{
			_transparenceyLevel = transparencyLevel;
		}

		public override string GetName ()
		{
			return "Quad3D";
		}

		public override double GetTransparencyLevel()
		{
			return _transparenceyLevel;
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

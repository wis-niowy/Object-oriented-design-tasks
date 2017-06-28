using System;
using System.Text;

namespace Graphics3D
{
	public class Triangle3D: FilledObject3D
	{
		private double _transparencyLevel;

		public Triangle3D (Colorspace colorspace, double transparencyLevel) : base(colorspace)
		{
			_transparencyLevel = transparencyLevel;
		}

		public override string GetName ()
		{
			return "Triangle3D";
		}

		public override double GetTransparencyLevel()
		{
			return _transparencyLevel;
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

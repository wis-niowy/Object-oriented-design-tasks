using System;
using System.Text;

namespace Graphics3D
{
	/**
	 * @brief Klasa Renderer
	 */
	public abstract class Renderer
	{
        //public abstract bool draw(Quad3D obj);
        //public abstract bool draw(Segment3D obj);
        //public abstract bool draw(Triangle3D obj);
        //public abstract bool draw(WireMesh3D obj);
        public abstract bool draw(WireframeObject3D obj);
        public abstract bool draw(FilledObject3D obj);


        public abstract bool canDraw(Quad3D obj);
        public abstract bool canDraw(Segment3D obj);
        public abstract bool canDraw(Triangle3D obj);
        public abstract bool canDraw(WireMesh3D obj);
    }
}

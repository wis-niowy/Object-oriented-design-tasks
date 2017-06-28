using System;
using System.Text;

namespace Graphics3D
{
	/**
	 * @brief Renderer OpenGL
	 * OpenGL potrafi rysować obiekty siatkowe i wypełnione bez ograniczeń grubości linii i stopnia przezroczystości.
	 * Obsługiwana jest wyłączenie przestrzeń kolorów RGB i domyślna (którą jest właśnie RGB).
	 */
	public class OpenGL : Renderer
	{
        //public override bool draw(Quad3D obj) // wypelniony
        //{
        //    if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
        //    string toReturn = String.Format("{0} rysuje wypelniony obiekt o nazwie '{1}' i przezroczystosci: '{2}' %", this.ToString(), obj.GetName(), obj.GetTransparencyLevel());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}
        //public override bool draw(Segment3D obj) // siatkowy
        //{
        //    if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
        //    string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}
        //public override bool draw(Triangle3D obj) // wypelniony
        //{
        //    if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
        //    string toReturn = String.Format("{0} rysuje wypelniony obiekt o nazwie '{1}' i przezroczystosci: '{2}' %", this.ToString(), obj.GetName(), obj.GetTransparencyLevel());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}
        //public override bool draw(WireMesh3D obj) // siatkowy
        //{
        //    if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
        //    string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}
        public override bool draw(FilledObject3D obj) // wypelniony
        {
            if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
            string toReturn = String.Format("{0} rysuje wypelniony obiekt o nazwie '{1}' i przezroczystosci: '{2}' %", this.ToString(), obj.GetName(), obj.GetTransparencyLevel());
            System.Console.WriteLine(toReturn);
            return true;
        }
        public override bool draw(WireframeObject3D obj) // siatkowy
        {
            if (obj.GetColorspace() != Colorspace.RGB && obj.GetColorspace() != Colorspace.Default) return false;
            string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
            System.Console.WriteLine(toReturn);
            return true;
        }

        public override bool canDraw(Quad3D obj) // wypelniony
        {
            return obj.GetColorspace() == Colorspace.RGB || obj.GetColorspace() == Colorspace.Default;
        }
        public override bool canDraw(Segment3D obj) // siatkowy
        {
            return obj.GetColorspace() == Colorspace.RGB || obj.GetColorspace() == Colorspace.Default;
        }
        public override bool canDraw(Triangle3D obj) // wypelniony
        {
            return obj.GetColorspace() == Colorspace.RGB || obj.GetColorspace() == Colorspace.Default;
        }
        public override bool canDraw(WireMesh3D obj) // siatkowy
        {
            return obj.GetColorspace() == Colorspace.RGB || obj.GetColorspace() == Colorspace.Default;
        }

        public override string ToString()
        {
            return "OpenGL";
        }
    }
}

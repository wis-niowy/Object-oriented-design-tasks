using System;
using System.Text;

namespace Graphics3D
{
	/**
	 * @brief Renderer Software
	 * Software renderer potrafi rysować wyłącznie obiekty siatkowe. Siatkowe nie mogą mieć grubości linii większej niż 3.0.
	 * Wszystkie przestrzenie kolorów są obsługiwane.
	 */
	public class Software : Renderer
    {
        //public override bool draw(Quad3D obj) // wypelniony
        //{
        //    return false;
        //}
        //public override bool draw(Segment3D obj) // siatkowy
        //{
        //    if (obj.GetLineWidth() > 3.0) return false;
        //    string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}
        //public override bool draw(Triangle3D obj) // wypelniony
        //{
        //    return false;
        //}
        //public override bool draw(WireMesh3D obj) // siatkowy
        //{
        //    if (obj.GetLineWidth() > 3.0) return false;
        //    string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
        //    System.Console.WriteLine(toReturn);
        //    return true;
        //}

        public override bool draw(FilledObject3D obj) // wypelniony
        {
            return false;
        }
        public override bool draw(WireframeObject3D obj) // siatkowy
        {
            if (obj.GetLineWidth() > 3.0) return false;
            string toReturn = String.Format("{0} rysuje siatkowy obiekt o nazwie '{1}' i grubosci linii: '{2}'", this.ToString(), obj.GetName(), obj.GetLineWidth());
            System.Console.WriteLine(toReturn);
            return true;
        }

        public override bool canDraw(Quad3D obj) // wypelniony
        {
            return false;
        }
        public override bool canDraw(Segment3D obj) // siatkowy
        {
            return obj.GetLineWidth() <= 3.0;
        }
        public override bool canDraw(Triangle3D obj) // wypelniony
        {
            return false;
        }
        public override bool canDraw(WireMesh3D obj) // siatkowy
        {
            return obj.GetLineWidth() <= 3.0;
        }

        public override string ToString()
        {
            return "Software";
        }
    }
}

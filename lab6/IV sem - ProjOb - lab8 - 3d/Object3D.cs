using System;
using System.Text;

namespace Graphics3D
{
	public enum Colorspace
	{
		Default,

		RGB,
		YUV,
		CMYK,
		XYZ
	}

	/**
	 * @brief Obiekt 3D posiada nazwę i przestrzeń kolorów z której korzysta.
	 * Może być domyślna (taką jaką obsługuje API) albo specyficzna, wedle żądania programisty.
	 */
	public abstract class Object3D
	{
		private Colorspace _colorspace;

		public Object3D (Colorspace colorspace)
		{
			_colorspace = colorspace;
		}

		public abstract string GetName ();

		public virtual Colorspace GetColorspace ()
		{
			return _colorspace;
		}

        //
        public abstract bool accept(Renderer renderer);
        public abstract bool canAcceptr(Renderer rend);
	}

	/**
	 * @brief Siatkowy obiekt 3D, posiada ustawienie grubości linii.
	 */
	public abstract class WireframeObject3D : Object3D
	{
		public WireframeObject3D(Colorspace car) : base(car) {}

		public abstract double GetLineWidth();
	}

	/**
	 * @brief Wypełniony obiekt 3D, posiada ustawienie stopnia przezroczystości (0.0 - 1.0)
	 */
	public abstract class FilledObject3D : Object3D
	{
		public FilledObject3D(Colorspace car) : base(car) {}

		public abstract double GetTransparencyLevel();
	}
}

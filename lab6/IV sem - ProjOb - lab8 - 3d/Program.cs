using System;
using System.Text;

namespace Graphics3D
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// część 1
			Console.WriteLine ("==> Rysowanie elementów 3D z użyciem różnych rendererów");

			Object3D[] objectsToPaint = new Object3D[]
			{
				new Triangle3D(Colorspace.RGB, 0.5),	// trójkąt RGB, 50 % przezroczystości
				new WireMesh3D(Colorspace.YUV, 2.0),	// siatka YUV, o grubości linii 2.0
				new Segment3D(Colorspace.CMYK, 5.0),	// odcinek CMYK, o grubości linii 5.0
				new Quad3D(Colorspace.XYZ, 0.23),		// czworobok XYZ, 23 % przezroczystości
				new Triangle3D(Colorspace.Default, 0.0) // trójkąt w domyślnej przestrzeni kolorów, 0 % przezroczystości (w pełni widoczny)
			};

			Console.WriteLine ("Lista elementów do narysowania:");

			int index = 0;

			foreach (Object3D p in objectsToPaint)
				Console.WriteLine ("[{0}] obiekt 3D '{1}' w przestrzeni kolorów '{2}'", ++index, p.GetName (), p.GetColorspace().ToString());

			Renderer[] availableRenderers = new Renderer[] {
				new Software(),
				new OpenGL(),
				new Direct3D()
			};

            /* UZUPEŁNIJ */
            int[] countRend = new int[availableRenderers.Length];
            foreach (var obj in objectsToPaint)
            {
                int it = 0;
                foreach(var rend in availableRenderers)
                {
                    if (obj.accept(rend))
                    {
                        countRend[it]++;
                    }
                    it++;
                }
            }

			// część 2
			Console.WriteLine("==> Wyznaczanie liczby rendererów na których można narysować konkretne obiekty");

			Object3D[] testObjects = new Object3D[] {
				new Triangle3D(Colorspace.Default, 0.5),
				new WireMesh3D(Colorspace.Default, 1.0),
				new Segment3D(Colorspace.Default, 1.0),
				new Quad3D(Colorspace.Default, 0.0)
			};

            /* UZUPEŁNIJ */
            
            foreach (var obj in testObjects)
            {
                int counter = 0;
                foreach (var rend in availableRenderers)
                {
                    if (obj.canAcceptr(rend))
                    {
                        counter++;
                    }
                }
                System.Console.WriteLine("Liczba renderow mogacych narysowac {0}: {1}", obj.GetName(), counter);
            }

            // część 3
            Console.WriteLine("==> Ile razy renderer narysował obiekt na ekranie");

            /* UZUPEŁNIJ */
            for (int i = 0; i < availableRenderers.Length; ++i)
                    System.Console.WriteLine("Renderer {0} narysowal {1} obiektow", i, countRend[i]);
		}
	}
}

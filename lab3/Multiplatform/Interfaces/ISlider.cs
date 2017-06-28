using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplatform.Interfaces
{
	public interface ISlider
	{
		float CurrentValue { get; }

		void ChangeValue(float value);

		void DrawContent();
	}
}

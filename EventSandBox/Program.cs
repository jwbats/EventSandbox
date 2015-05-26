using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSandBox
{
	class Program
	{

		static void Main(string[] args)
		{
			Metronome metronome = new Metronome();
			MetronomeListener listener = new MetronomeListener(metronome);
			metronome.Start();
			Console.WriteLine("Press key.");
			Console.ReadKey();
		}

	}
}

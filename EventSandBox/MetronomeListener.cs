using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSandBox
{
	public class MetronomeListener
	{

		#region ================================================== Private Members ==================================================

		private Metronome metronome;

		private Metronome.TickHandler myTickHandler;

		#endregion ================================================== Private Members ==================================================




		#region ================================================== Private Methods ==================================================

		private void TheActualEvent(Metronome metronome, EventArgsTicks eventArgsTicks)
		{
			Console.WriteLine(eventArgsTicks.Ticks);
		}




		private void Subscribe()
		{
			this.metronome.Tick += this.myTickHandler;
		}




		private void Unsubscribe()
		{
			this.metronome.Tick -= this.myTickHandler;
		}

		#endregion ================================================== Private Methods ==================================================




		#region ================================================== Constructor / Destructor ==================================================

		public MetronomeListener(Metronome metronome)
		{
			this.metronome = metronome;
			this.myTickHandler = new Metronome.TickHandler(TheActualEvent);

			Subscribe();
		}




		~MetronomeListener()
		{
			Unsubscribe();
		}

		#endregion ================================================== Constructor / Destructor ==================================================

	}
}

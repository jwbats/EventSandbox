using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSandBox
{
	public class Metronome
	{

		#region ================================================== Event Stuff ==================================================

		public delegate void TickHandler(Metronome metronome, EventArgsTicks eventArgsTicks);
		public event TickHandler Tick;

		#endregion ================================================== Event Stuff ==================================================




		#region ================================================== Public Methods ==================================================

		public void Start()
		{
			for (int i = 0; i < 4; i++)
			{
				System.Threading.Thread.Sleep(1000);

				EventArgsTicks eventArgsTicks = new EventArgsTicks()
				{
					Ticks = DateTime.Now.Ticks
				};

				if (Tick != null)
				{
					Console.WriteLine("Number of events registered: {0}", this.Tick.GetInvocationList().Length);
					this.Tick(this, eventArgsTicks);
				}
			}
		}

		#endregion ================================================== Public Methods ==================================================

	}
}

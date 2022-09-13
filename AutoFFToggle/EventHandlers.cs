using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace AutoFFToggle
{
    public class EventHandler
	{
		public void OnRoundStartEvent()
		{
            {
                Server.FriendlyFire = false;
            }
        }

		public void OnEndingRoundEvent(EndingRoundEventArgs ev)
		{
			if (ev.IsAllowed && ev.IsRoundEnded)
			{
                {
                    Server.FriendlyFire = true;
                }
            }
		}
	}
}
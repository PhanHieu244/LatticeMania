public class WorldController : BaseController
{
	public void OnDailyGiftReached()
	{
		return;
		Timer.Schedule(this, 0.5f, delegate
		{
			DialogController.instance.ShowDialog(DialogType.DailyGift);
		});
	}
}

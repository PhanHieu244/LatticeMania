public class CompleteDialog : Dialog
{
	public void OnReplayClick()
	{
		Close();
		Sound.instance.PlayButton();
		MainController.instance.Replay();
	}

	public void OnNextClick()
	{
		Close();
		Sound.instance.PlayButton();
		if (GameState.chosenLevel == 60)
		{
			CUtils.LoadScene(1, true);
			return;
		}
		GameState.chosenLevel++;
		CUtils.LoadScene(3, true);
	}

	public override void Close()
	{
		CUtils.ShowInterstitialAd();
		base.Close();
	}
}

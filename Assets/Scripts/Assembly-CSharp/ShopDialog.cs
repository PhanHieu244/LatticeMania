using UnityEngine.UI;

public class ShopDialog : Dialog
{
	
	public Text[] numHintTexts;

	public Text[] priceTexts;

	protected override void Start()
	{
		/*base.Start();
		int num = 0;
		Text[] array = numHintTexts;
		foreach (Text text in array)
		{
			text.text = Purchaser.instance.iapItems[num].value + " hints";
			num++;
		}
		num = 0;
		Text[] array2 = priceTexts;
		foreach (Text text2 in array2)
		{
			text2.text = Purchaser.instance.iapItems[num].price + "$";
			num++;
		}*/
	}

	/*public override void Close()
	{
		base.Close();
		//SubscriptionsPopup.instance.Show(Purchaser.m_StoreController, 1.5f);
	}*/

	public void OnBuyProduct(int index)
	{
		switch (index)
		{
			case 1:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(10);
				};
				IAPManager.Instance.BuyProductID(IAPKey.PACK1);
				break;
			case 2:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(20);
				};
				IAPManager.Instance.BuyProductID(IAPKey.PACK2);
				break;
			case 3:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(60);
				};				
				IAPManager.Instance.BuyProductID(IAPKey.PACK3);
				break;
			case 4:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(100);
				};				
				IAPManager.Instance.BuyProductID(IAPKey.PACK4);
				break;
			case 5:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(200);
				};				
				IAPManager.Instance.BuyProductID(IAPKey.PACK5);
				break;
			case 6:
				IAPManager.OnPurchaseSuccess = () =>
				{
					GameState.hint.ChangeValue(400);
				};				
				IAPManager.Instance.BuyProductID(IAPKey.PACK6);
				break;
		}
	}
}

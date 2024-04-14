using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Purchase
{
    public class PurchasePopMainMenuBehaviour : MonoBehaviour
    {
        public Button[] MainMenuButtons;

        public void OpenPurchase()
        {
            foreach (Button button in MainMenuButtons)
            {
                button.interactable = false;
            }
        }

        public void ClosePurchase()
        {
            foreach (Button button in MainMenuButtons)
            {
                button.interactable = true;
            }
        }
    }
}

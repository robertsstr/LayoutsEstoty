using TMPro;
using UnityEngine;

namespace Assets.Scripts.Purchase
{
    public class ShopScript : MonoBehaviour
    {
        public GameObject BonusBannerImage;
        public TextMeshProUGUI InitialBuckAmount;
        public TextMeshProUGUI BonusPercentage;
        public TextMeshProUGUI WithBonusBuckAmount;
        public TextMeshProUGUI BucksOwnedTotal;

        public int Bonus = 100;

        public void Start()
        {
            if (Bonus <= 0)
            {
                BonusBannerImage.SetActive(false);
                WithBonusBuckAmount.text = "";
            }
            else
            {
                int.TryParse(InitialBuckAmount.text, out int initialAmount);
                
                float withBonusAmount = initialAmount * (1f + (Bonus / 100f));

                BonusPercentage.text = Bonus + "%";
                InitialBuckAmount.alpha = 0.5f;
                WithBonusBuckAmount.text = withBonusAmount.ToString();
            }
        }

        public void GetBucks()
        {
            int.TryParse(BucksOwnedTotal.text, out int currentTotal);
            int newTotal;

            if (Bonus <= 0)
            {
                newTotal = currentTotal + int.Parse(InitialBuckAmount.text);
            }
            else
            {
                newTotal = currentTotal + int.Parse(WithBonusBuckAmount.text);
            }

            BucksOwnedTotal.text = newTotal.ToString();
        }
    }
}

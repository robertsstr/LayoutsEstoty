using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.Purchase
{
    public class PurchasePanelAnimation : MonoBehaviour
    {
        public GameObject PurchasePanel;

        public void PanelOpen()
        {
            PurchasePanel.SetActive(true);
            PurchasePanel.transform.localScale = Vector3.zero;
            PurchasePanel.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
        }
    }
}

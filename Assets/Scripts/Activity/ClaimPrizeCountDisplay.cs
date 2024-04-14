using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Activity
{
    public class ClaimPrizeCountDisplay : MonoBehaviour
    {
        public GameObject CountNotification;
        public TextMeshProUGUI Counter;

        void Start()
        {
            Sequence hover = DOTween.Sequence();
            hover.Append(CountNotification.transform.DOScale(1.1f, 0.5f / 2))
                .Append(CountNotification.transform.DOScale(1f, 0.5f / 2))
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
        }

        void Update()
        {
            int activePanelCount = ClaimPrizeCountTracker.GetActivePanelsCount();
            CountNotification.SetActive(activePanelCount > 0);
            Counter.text = activePanelCount.ToString();
        }
    }
}

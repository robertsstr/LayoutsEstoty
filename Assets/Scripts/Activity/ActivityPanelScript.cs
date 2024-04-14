using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Activity
{
    public class ActivityPanelScript : MonoBehaviour
    {
        public int MaxPoints;
        public int CurrentPoints = 0;
        public GameObject ProgressPanel;
        public GameObject ClaimPanel;
        public ActivityBarScript ActivityBarScript;
        public TextMeshProUGUI ActivityCounter;
        public Button ClaimButton;

        public void Start()
        {
            ProgressPanel.SetActive(true);
            ClaimPanel.SetActive(false);
            UpdateActivityCounter();
        }

        public void AddPointsOnClick()
        {
            CurrentPoints++;
            UpdateActivityCounter();
            CheckMaxPoints();
        }

        public void CheckMaxPoints()
        {
            if (CurrentPoints >= MaxPoints)
            {
                ProgressPanel.SetActive(false);
                ClaimPanel.SetActive(true);
                ClaimPrizeCountTracker.IncrementActivePanels();

                AnimateClaimPanel();
            }
        }

        public void UpdateActivityCounter()
        {
            ActivityCounter.text = $"{CurrentPoints}/{MaxPoints}";
        }

        public void ClaimPrize()
        {
            if (ActivityBarScript.Slider.value >= 100f)
            {
                ClaimButton.interactable = false;
                return;
            }

            float newValue = ActivityBarScript.Slider.value + 25;
            ActivityBarScript.Slider.DOValue(newValue, 0.3f).OnComplete(() => {
                ActivityBarScript.Points.text = ((int)newValue).ToString();
            });

            CurrentPoints = 0;
            ProgressPanel.SetActive(true);
            ClaimPanel.SetActive(false);
            UpdateActivityCounter();

            ClaimButton.interactable = true;
            ClaimPrizeCountTracker.DecrementActivePanels();
        }

        private void AnimateClaimPanel()
        {
            ClaimPanel.transform.localScale = Vector3.zero;
            ClaimPanel.transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
        }
    }
}

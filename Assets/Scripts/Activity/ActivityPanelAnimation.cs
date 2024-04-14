using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.Activity
{
    public class ActivityPanelAnimation : MonoBehaviour
    {
        public RectTransform ActivityPanel;
        public RectTransform ExitButton;

        public void ActivityFlyIn()
        {
            Vector2 targetPosition = new Vector2(48.29089f, 158f);
            ActivityPanel.DOAnchorPos(targetPosition, 1f).SetEase(Ease.OutBounce);

            Vector2 exitButtonTargetPosition = new Vector2(-484, 1647);
            ExitButton.DOAnchorPos(exitButtonTargetPosition, 0.5f).SetEase(Ease.OutQuad);
        }

        public void ActivityFlyOut()
        {
            Vector2 targetPosition = new Vector2(48.29089f, -1449.632f);
            ActivityPanel.DOAnchorPos(targetPosition, 0.5f).SetEase(Ease.OutQuad);

            Vector2 exitButtonTargetPosition = new Vector2(-692, 1647);
            ExitButton.DOAnchorPos(exitButtonTargetPosition, 0.5f).SetEase(Ease.OutQuad);
        }
    }
}

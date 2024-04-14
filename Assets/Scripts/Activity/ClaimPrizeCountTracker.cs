using UnityEngine;

namespace Assets.Scripts.Activity
{
    public class ClaimPrizeCountTracker : MonoBehaviour
    {
        private static int _activeClaimPanels = 0;

        public static void IncrementActivePanels()
        {
            _activeClaimPanels++;
        }

        public static void DecrementActivePanels()
        {
            if (_activeClaimPanels > 0)
                _activeClaimPanels--;
        }

        public static int GetActivePanelsCount()
        {
            return _activeClaimPanels;
        }
    }
}

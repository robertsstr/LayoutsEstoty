using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Activity
{
    public class ActivityBarScript : MonoBehaviour
    {
        public Slider Slider;
        public TextMeshProUGUI Points;

        public void SetPoints(int points)
        {
            Slider.value = points;
            Points.text = points.ToString();
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

namespace com.Klazapp.Utility
{
    [CreateAssetMenu(fileName = "Progress Bar Template", menuName = "Klazapp/Loader/Templates/Progress Bar Animator", order = 3)]
    public class ProgressBarAnimator : LoadingProgressTemplate
    {
        public override void ProgressBarLoader(Slider slider, float sliderValue)
        {
            slider.value = sliderValue;
        }
    }
}

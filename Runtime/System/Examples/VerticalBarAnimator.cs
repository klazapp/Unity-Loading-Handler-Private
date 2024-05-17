using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.Klazapp.Utility
{
    [CreateAssetMenu(fileName = "Vertical Bar Animator Template", menuName = "Klazapp/Loader/Templates/Vertical Bar Animator", order = 1)]
    public class VerticalBarAnimator : LoadingAnimatorTemplate
    {
        #region Variables
        public float barMoveHeight = 100f; // The height the bars will move up and down
        public float delayBetweenBars = 0.2f; // Delay in seconds between the movement of each bar
        public float endCycleDelay = 0.5f; // Delay after the third bar has gone up and down
        #endregion

        #region Lifecycle Flow
        public override void UpdateLoader(RectTransform[] rectTransforms, float normalizedTime)
        {
            if (rectTransforms == null || rectTransforms.Length != 3)
            {
                Debug.LogError("VerticalBarAnimator requires exactly 3 bars.");
                return;
            }

            float totalAnimationDuration = animationDuration + 2 * delayBetweenBars + endCycleDelay;
            float adjustedTime = (normalizedTime * totalAnimationDuration) % totalAnimationDuration;

            float bar1Time = Mathf.Clamp01(adjustedTime / animationDuration);
            float bar2Time = Mathf.Clamp01((adjustedTime - delayBetweenBars) / animationDuration);
            float bar3Time = Mathf.Clamp01((adjustedTime - 2 * delayBetweenBars) / animationDuration);

            UpdateBar(rectTransforms[0], bar1Time);
            UpdateBar(rectTransforms[1], bar2Time);
            UpdateBar(rectTransforms[2], bar3Time);
        }
        #endregion

        #region Modules
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateBar(RectTransform bar, float time)
        {
            var yPosition = Mathf.Sin(time * 2 * Mathf.PI) * barMoveHeight;
            bar.anchoredPosition = new Vector2(bar.anchoredPosition.x, yPosition);
        }
        #endregion
    }
}
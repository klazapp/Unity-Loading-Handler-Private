using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.Klazapp.Utility
{
    [CreateAssetMenu(fileName = "Circular Dot Animator Template", menuName = "Klazapp/Loader/Templates/Circular Dot Animator", order = 2)]
    public class CircularDotAnimatorTemplate : LoadingAnimatorTemplate
    {
        #region Variables
        public float radius = 100f; // The radius of the circle
        public float delayBetweenDots = 0.2f; // Delay in seconds between the movement of each dot
        public float endCycleDelay = 0.5f; // Delay after the last dot has finished
        public Vector3 startScale = Vector3.one; // Starting scale of the dots
        public Vector3 targetScale = Vector3.one * 2f; // Target scale of the dots
        #endregion

        #region Lifecycle Flow
        public override void UpdateLoader(RectTransform[] rectTransforms, float normalizedTime)
        {
            if (rectTransforms == null || rectTransforms.Length != 6)
            {
                Debug.LogError("CircularDotAnimatorTemplate requires exactly 6 dots.");
                return;
            }

            float totalAnimationDuration = animationDuration + 5 * delayBetweenDots + endCycleDelay;
            float adjustedTime = (normalizedTime * totalAnimationDuration) % totalAnimationDuration;

            for (int i = 0; i < rectTransforms.Length; i++)
            {
                float dotTime = Mathf.Clamp01((adjustedTime - i * delayBetweenDots) / animationDuration);
                UpdateDot(rectTransforms[i], dotTime);
            }
        }
        #endregion

        #region Modules
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateDot(RectTransform dot, float time)
        {
            float angle = time * 2 * Mathf.PI;
            float xPosition = Mathf.Cos(angle) * radius;
            float yPosition = Mathf.Sin(angle) * radius;
            dot.anchoredPosition = new Vector2(xPosition, yPosition);

            // Calculate and apply scaling based on time
            Vector3 currentScale = Vector3.Lerp(startScale, targetScale, time);
            dot.localScale = currentScale;
        }
        #endregion
    }
}

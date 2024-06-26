using UnityEngine;

namespace com.Klazapp.Utility
{
    public class JumpingBarLoadingAnimator : MonoBehaviour
    {
        #region Variables
        [Header("Animated Rect Transforms")]
        [SerializeField]
        private RectTransform[] animatedRectTransforms;
        
        [Header("Animator Template")]
        [SerializeField]
        private LoadingAnimatorTemplate loadingAnimatorTemplate;
        #endregion
        
        #region Lifecyle Flow
        private void Update()
        {
            if (loadingAnimatorTemplate == null)
                return;

            var normalizedTime = (Time.time % loadingAnimatorTemplate.animationDuration) / loadingAnimatorTemplate.animationDuration;

            loadingAnimatorTemplate.UpdateLoader(animatedRectTransforms, normalizedTime);
        }
        #endregion
    }
}
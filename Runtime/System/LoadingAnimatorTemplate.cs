using UnityEngine;

namespace com.Klazapp.Utility
{
    public abstract class LoadingAnimatorTemplate : ScriptableObject
    {
        #region Variables
        public float animationDuration = 1f;
        #endregion
        
        #region Lifecycle Flow
        public abstract void UpdateLoader(RectTransform[] rectTransforms, float normalizedTime);
        #endregion
    }
}

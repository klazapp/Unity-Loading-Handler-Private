using UnityEngine;
using UnityEngine.UI;

namespace com.Klazapp.Utility
{
    public class ProgressBarLoadingAnimator : MonoBehaviour
    {
        #region Variables
        [Header("Slider")]
        [SerializeField]
        private Slider slider;
        
        public float ProgressValue { get; set; }
        
        [Header("Progress Bar Animator Template")]
        [SerializeField]
        private LoadingProgressTemplate loadingProgressTemplate;
        #endregion
        
        #region Lifecyle Flow
        private void Update()
        {
            if (loadingProgressTemplate == null)
                return;

            loadingProgressTemplate.ProgressBarLoader(slider, ProgressValue);
        }
        #endregion
    }
}

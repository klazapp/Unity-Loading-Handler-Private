using TMPro;
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
    
        [Header("Progress Text")]
        [SerializeField]
        private TextMeshProUGUI progressionText;
        
        [Header("Progress Bar Animator Template")]
        [SerializeField]
        private LoadingProgressTemplate loadingProgressTemplate;
        #endregion
        
        #region Lifecyle Flow
        private void Update()
        {
            if (loadingProgressTemplate == null)
                return;

            var currentProgress = LoadingEventManager.RetrieveProgress();
            loadingProgressTemplate.ProgressBarLoader(slider, currentProgress);

            var progressDownload = LoadingEventManager.RetrieveProgressDownload();
            loadingProgressTemplate.ProgressDownloadTextLoader(progressionText, progressDownload);
        }
        #endregion
    }
}

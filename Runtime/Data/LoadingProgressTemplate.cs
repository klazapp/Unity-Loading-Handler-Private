using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace com.Klazapp.Utility
{
    public abstract class LoadingProgressTemplate : ScriptableObject
    {
        #region Lifecycle Flow
        public abstract void ProgressBarLoader(Slider slider, float sliderValue);

        public abstract void ProgressDownloadTextLoader(TextMeshProUGUI progressText, string progressTexValue);
        #endregion
    }
}

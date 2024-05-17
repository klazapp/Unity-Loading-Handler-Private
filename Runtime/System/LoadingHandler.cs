using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.Klazapp.Utility
{
    public class LoadingUIManager : MonoBehaviour
    {
        #region Variables
        [Header("Canvas")]
        public Canvas canvas;
        #endregion
        
        #region Lifecycle Flow
        private void OnEnable()
        {
            LoadingEventManager.OnLoadingStarted += LoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded += LoadingEndedCallback;
        }

        private void OnDisable()
        {
            LoadingEventManager.OnLoadingStarted -= LoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded -= LoadingEndedCallback;
        }
        #endregion

        #region Modules
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void EnableCanvas()
        {
            canvas.enabled = true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void DisableCanvas()
        {
            canvas.enabled = false;
        }
        #endregion
        
        #region Callback
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void LoadingStartedCallback()
        {
            EnableCanvas();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void LoadingEndedCallback()
        {
            DisableCanvas();
        }
        #endregion
    }
}

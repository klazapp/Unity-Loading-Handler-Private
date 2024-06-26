using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    public class ProgressBarLoadingHandler : LoadingHandler
    {
        #region Lifecycle Flow

        private void OnEnable()
        {
            LoadingEventManager.OnProgressLoadingStarted += ProgressLoadingStartedCallback;
            LoadingEventManager.OnProgressLoadingEnded += ProgressLoadingEndedCallback;
        }

        private void OnDisable()
        {
            LoadingEventManager.OnProgressLoadingStarted -= ProgressLoadingStartedCallback;
            LoadingEventManager.OnProgressLoadingEnded -= ProgressLoadingEndedCallback;
        }

        #endregion

        #region Callback

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ProgressLoadingStartedCallback()
        {
            EnableCanvas();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ProgressLoadingEndedCallback()
        {
            DisableCanvas();
        }

        #endregion
    }
}

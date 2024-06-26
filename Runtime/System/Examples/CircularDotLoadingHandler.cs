using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    public class CircularDotLoadingHandler : LoadingHandler
    {
        #region Lifecycle Flow

        private void OnEnable()
        {
            LoadingEventManager.OnLoadingStarted += CircularDotLoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded += CircularDotLoadingEndedCallback;
        }

        private void OnDisable()
        {
            LoadingEventManager.OnLoadingStarted -= CircularDotLoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded -= CircularDotLoadingEndedCallback;
        }

        #endregion

        #region Callback

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void CircularDotLoadingStartedCallback()
        {
            EnableCanvas();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void CircularDotLoadingEndedCallback()
        {
            DisableCanvas();
        }

        #endregion
    }
}

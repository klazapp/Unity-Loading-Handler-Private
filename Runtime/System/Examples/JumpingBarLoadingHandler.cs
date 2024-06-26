using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    public class JumpingBarLoadingHandler : LoadingHandler
    {
        #region Lifecycle Flow

        private void OnEnable()
        {
            LoadingEventManager.OnLoadingStarted += JumpingBarLoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded += JumpingBarLoadingEndedCallback;
        }

        private void OnDisable()
        {
            LoadingEventManager.OnLoadingStarted -= JumpingBarLoadingStartedCallback;
            LoadingEventManager.OnLoadingEnded -= JumpingBarLoadingEndedCallback;
        }

        #endregion

        #region Callback

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void JumpingBarLoadingStartedCallback()
        {
            EnableCanvas();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void JumpingBarLoadingEndedCallback()
        {
            DisableCanvas();
        }

        #endregion
    }
}

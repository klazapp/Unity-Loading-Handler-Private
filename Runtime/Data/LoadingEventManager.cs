using System;

namespace com.Klazapp.Utility
{
    public static class LoadingEventManager
    {
        public static event Action OnLoadingStarted;
        public static void InvokeLoadingStarted()
        {
            OnLoadingStarted?.Invoke();
        }

        public static event Action OnLoadingEnded;
        public static void InvokeLoadingEnded()
        {
            OnLoadingEnded?.Invoke();
        }
        
        public static event Action OnProgressLoadingStarted;
        public static void InvokeProgressLoadingStarted()
        {
            OnProgressLoadingStarted?.Invoke();
        }
        
        public static event Action OnProgressLoadingEnded;
        public static void InvokeProgressLoadingEnded()
        {
            OnProgressLoadingEnded?.Invoke();
        }
        
    }
}
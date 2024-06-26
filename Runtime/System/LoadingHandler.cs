using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.Klazapp.Utility
{
    public class LoadingHandler : MonoBehaviour
    {
        #region Variables
        [Header("Canvas")]
        public Canvas canvas;
        #endregion

        #region Modules
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void EnableCanvas()
        {
            canvas.enabled = true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void DisableCanvas()
        {
            canvas.enabled = false;
        }
        #endregion
    }
}

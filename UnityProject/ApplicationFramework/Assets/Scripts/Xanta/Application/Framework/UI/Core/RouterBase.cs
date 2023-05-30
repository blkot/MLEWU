using UnityEngine;

namespace Xanta.Application.Framework.UI.Core
{
    public static class RouterBase
    {
        public static ScreenState Current { get; private set; }

        public static void ChangeState(ScreenState newState)
        {
            Current?.Hide();
            Current = newState;
            Current?.Show();
        }
    }
}
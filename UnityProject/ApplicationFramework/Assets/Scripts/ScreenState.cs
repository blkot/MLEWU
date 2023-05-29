using UnityEngine;

namespace Xanta.Application.Framework.UI.Core
{
    public abstract class ScreenState : MonoBehaviour
    {
        public abstract void Initialize();
        public abstract void Show();
        public abstract void Hide();
    }
}
using UnityEngine;
using static Xanta.Application.Framework.UI.Core.RouterBase;
using MainMenuState = Xanta.Application.Framework.UI.MainMenu.MainMenuState;

namespace Xanta.Application.Framework.UI.Core
{
    public static class Router
    {
        public static void GoToMainMenu() => ChangeState(MainMenuState.Instance);
    }
}
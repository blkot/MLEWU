using UnityEngine;
using Xanta.Application.Framework.UI.Core;

namespace Xanta.Application.Framework.UI.MainMenu
{
    public class MainMenuState : ScreenState<MainMenuState, MainMenuView>
    {
        public override void Initialize()
        {
            base.Initialize();
            view.MessageChangerBtn.onClick.AddListener(ChangeMessage);
        }

        void ChangeMessage()
        {
            view.MessageTxt.text = "Message is changed!";
        }
    }
}
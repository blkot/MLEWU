using TMPro;
using Xanta.Application.Framework.UI.Core;
using UnityEngine.UI;
using UnityEngine;

namespace Xanta.Application.Framework.UI.MainMenu
{
    public class MainMenuView : MonoBehaviour
    {
        [field: SerializeField] public Button MessageChangerBtn { get; private set; }
        [field: SerializeField] public TextMeshProUGUI MessageTxt { get; private set; }
    }
}
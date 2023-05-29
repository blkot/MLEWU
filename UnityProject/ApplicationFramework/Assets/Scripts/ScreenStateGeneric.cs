using UnityEngine;

namespace Xanta.Application.Framework.UI.Core
{
    public abstract class ScreenState<TState, TView> : ScreenState
        where TState : ScreenState where TView : MonoBehaviour
    {
        private const string VIEWS_ADDRESS_IN_RESOURCE = "Views/";

        #region Singleton

        private static TState instance;
        public static TState Instance => instance ?? InitInstance();

        private static TState InitInstance()
        {
            instance = new GameObject(typeof(TState).Name).AddComponent<TState>();
            instance.Initialize();
            return instance;
            // throw new System.NotImplementedException();
        }

        #endregion

        protected TView view;

        protected virtual string ViewAddress => VIEWS_ADDRESS_IN_RESOURCE + typeof(TView).Name;

        public override void Initialize()
        {
            view = Instantiate(Resources.Load<GameObject>(VIEWS_ADDRESS_IN_RESOURCE).GetComponent<TView>());
            throw new System.NotImplementedException();
        }

        public override void Show()
        {
            throw new System.NotImplementedException();
        }

        public override void Hide()
        {
            throw new System.NotImplementedException();
        }
    }
}
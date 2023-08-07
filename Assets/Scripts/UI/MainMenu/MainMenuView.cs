using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class MainMenuView : MonoBehaviour, IUiView
    {
        private MainMenuController controller;
        public void SetController(MainMenuController controllerToSet)
        {
            controller = controllerToSet;
        }

        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class MainMenuUIController
    {
        private MainMenuView mainMenuView;

        public MainMenuUIController(MainMenuView mainMenuView)
        {
            this.mainMenuView = mainMenuView;
        }

        public void DisableView() => mainMenuView.gameObject.SetActive(false);

        public void EnableView() => mainMenuView.gameObject.SetActive(true);

        public void OnClickPlayBtn()
        {
            DisableView();
            GameService.Instance.UIService.StartGameplay();
        }

        public void OnClickOptionsBtn()
        {
            DisableView();
            GameService.Instance.UIService.EnableOptionsScreen();
        }
    }
}

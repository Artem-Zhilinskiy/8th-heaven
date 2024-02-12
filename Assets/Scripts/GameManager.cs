using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace EightHeaven
{
    public class GameManager : MonoBehaviour
    {
        public static byte chosenPC;
        /*
         * 0 - Princess;
         * 1 - Paladin;
         * 2 - Witch;
         * 3 - The Cursed One; 
         */
        public static int actions = 3;

        [SerializeField]
        private TextMeshProUGUI actionLabel;
        [SerializeField]
        private TextMeshProUGUI currentDayLabel;

        //Number of actions per day
        private int actionsPerDay = 3;
        //Day number
        private int dayNumber = 0;

        #region buttons
        [Header ("Noble quarters buttons")]
        [SerializeField]
        private  Button PrincessChambersButton;
        [SerializeField]
        private  Button NobleQuartersButton;
        [SerializeField]
        private  Button CouncilButton;

        [Header("City buttons")]
        [SerializeField]
        private  Button ShopButton;
        [SerializeField]
        private  Button SmithButton;
        [SerializeField]
        private  Button AlchemistButton;
        [SerializeField]
        private  Button LibaryButton;
        [SerializeField]
        private  Button BrothelButton;
        [SerializeField]
        private  Button TownWalkButton;
        [SerializeField]
        private  Button MadamHouseButton;

        [Header("Suburb buttons")]
        [SerializeField]
        private  Button FortButton;
        [SerializeField]
        private  Button ForestButton;
        [SerializeField]
        private  Button FarmsButton;
        [SerializeField]
        private  Button CampButton;
        #endregion

        #region MainQuest
        private int stage = 0; //Stage of the main quest.
        private string[] questLocations = new string[] { "FortButton", "FortButton", "ForestButton" }; //Location of the current quest stage.
                                                  //TODO: create massives for questlocations and hints. Element number will be stage number.
        private string hint; //Hint of the current quest stage.

        public void ProgressStage()
        {
            stage++;
            //RenewHint();
            Debug.Log("stage of main quest is " + stage.ToString());
        }

        /*
         * любая кнопка локации
         * 1. Проверка на то, является ли сейчас локация квестовой.
         * 1.1. Если да, то активировать панель, соотвтствующей стадии квеста (Так же через массив, как и локации). 
         * Отключается основная панель. Вызывается ProgressStage.
         * 2. Если нет, то пройти проверку на второстепенный квест.
         * 3. Если обе проверки показали, что в локации квеста нет, то разыгрывается случайной событие.
         */

        private bool CheckMainQuestLoc(Button button)
        {
            if (button.name == questLocations[stage]) return true;
            else return false;
        }

        public void AnyLocation(Button button)
        {
            if (CheckMainQuestLoc(button))
            {
                Debug.Log("This is main quest Location. Stage is " + stage.ToString());
                OpenQuestPanel(FindMainQuestPanel(stage));
            }
            else
            {
                Debug.Log("This location does not have main quest currently");
            }
        }

        private void RenewHint()
        {

        }
        #endregion

        #region PanelManagement
        [Header("Panels")]
        [SerializeField]
        private GameObject MainPanel;
        [SerializeField]
        private GameObject MainQuestPanel00;
        [SerializeField]
        private GameObject MainQuestPanel01;
        [SerializeField]
        private GameObject MainQuestPanel02;
        [SerializeField]
        private GameObject MainQuestPanel02_2;

        public void TurnOffButton(Button button)
        {
            button.interactable = false;
        }

        public void OpenQuestPanel(GameObject panel)
        {
            MainPanel.SetActive(false);
            panel.SetActive(true);
        }

        public void ReturnToMainPanel(GameObject panel)
        {
            panel.SetActive(false);
            MainPanel.SetActive(true);
        }

        public void TurnOffPanel(GameObject panel)
        {
            panel.SetActive(false);
        }

        public void TurnOnPanel(GameObject panel)
        {
            panel.SetActive(true);
        }

        private GameObject FindMainQuestPanel(int stage)
        {
            switch (stage)
            { 
                case 0:
                    return MainQuestPanel00;
                case 1:
                    return MainQuestPanel01;
                case 2:
                    return MainQuestPanel02;
                default: return null;
            }
        }

        #endregion

        public void NextDay()
        {
            Debug.Log("Next day is triggered");
            RenewActions();
            RenewButtons();
            dayNumber++;
            currentDayLabel.text = dayNumber.ToString();
            actionLabel.text = actions.ToString();
        }

        private void RenewActions()
        {
            AnnulateActions();
            AddActions(actionsPerDay);
        }

        private void AnnulateActions()
        {
            actions = 0;
        }

        private void AddActions(int actionsToAdd)
        {
            actions += actionsToAdd;
        }

        private void RenewButtons()
        {
            PrincessChambersButton.interactable = true;
            NobleQuartersButton.interactable = true;
            CouncilButton.interactable = true;
            ShopButton.interactable = true;
            SmithButton.interactable = true;
            AlchemistButton.interactable = true;
            LibaryButton.interactable = true;
            BrothelButton.interactable = true;
            TownWalkButton.interactable = true;
            MadamHouseButton.interactable = true;
            FortButton.interactable = true;
            ForestButton.interactable = true;
            FarmsButton.interactable = true;
            CampButton.interactable = true;
    }
    }
}

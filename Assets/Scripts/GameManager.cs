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
        private static Button PrincessChambersButton;
        [SerializeField]
        private static Button NobleQuartersButton;
        [SerializeField]
        private static Button CouncilButton;

        [Header("City buttons")]
        [SerializeField]
        private static Button ShopButton;
        [SerializeField]
        private static Button SmithButton;
        [SerializeField]
        private static Button AlchemistButton;
        [SerializeField]
        private static Button LibaryButton;
        [SerializeField]
        private static Button BrothelButton;
        [SerializeField]
        private static Button TownWalkButton;
        [SerializeField]
        private static Button MadamHouseButton;

        [Header("Suburb buttons")]
        [SerializeField]
        private static Button FortButton;
        [SerializeField]
        private static Button ForestButton;
        [SerializeField]
        private static Button FarmsButton;
        [SerializeField]
        private static Button CampButton;
        #endregion

        #region MainQuest
        private int stage = 0; //Stage of the main quest.
        private string[] questLocations = new string[] { "FortButton", "ForestButton" }; //Location of the current quest stage.
                                                  //TODO: create massives for questlocations and hints. Element number will be stage number.
        private string hint; //Hint of the current quest stage.

        public void ProgressStage()
        {
            stage++;
            RenewHint();
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

        public void NextDay()
        {
            Debug.Log("Next day is triggered");
            RenewActions();
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
    }
}

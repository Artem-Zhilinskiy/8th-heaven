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
         * ����� ������ �������
         * 1. �������� �� ��, �������� �� ������ ������� ���������.
         * 1.1. ���� ��, �� ������������ ������, �������������� ������ ������ (��� �� ����� ������, ��� � �������). 
         * ����������� �������� ������. ���������� ProgressStage.
         * 2. ���� ���, �� ������ �������� �� �������������� �����.
         * 3. ���� ��� �������� ��������, ��� � ������� ������ ���, �� ������������� ��������� �������.
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

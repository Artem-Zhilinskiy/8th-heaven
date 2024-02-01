using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

        public void NextDay()
        {
            Debug.Log("Next day is triggered");
            AnnulateActions();
            AddActions(actionsPerDay);
            dayNumber++;
            currentDayLabel.text = dayNumber.ToString();
            actionLabel.text = actions.ToString();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EightHeaven
{
    public class MainQuestManager : MonoBehaviour
    {
        private int stage; //Stage of the main quest.
        private string questLocation; //Location of the current quest stage.
                                      //TODO: create massives for questlocations and hints. Element number will be stage number.
        private string hint; //Hint of the current quest stage.
        public void ProgressStage()
        {
            stage++;
            RenewHint();
        }

        private void RenewHint()
        {

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EightHeaven
{
    public class HeroChoiceScript : MonoBehaviour
    {
        public void PrincessIsChosen()
        {
            GameManager.chosenPC = 0;
            Debug.Log("Princess is chosen as PC");
            Debug.Log(GameManager.chosenPC);
        }
    }
}
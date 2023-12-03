using UnityEngine;

namespace EightHeaven
{
    public class DisclaimerMenuScript : MonoBehaviour
    {
        [SerializeField]
        private int _levelToLoad;

        [SerializeField]
        private SceneFaderScript _sceneFader;

        public void Play()
        {
            _sceneFader.FadeTo(_levelToLoad);
        }

        public void Quit()
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
using UnityEngine;

namespace EightHeaven
{
    public class MainMenuScript : MonoBehaviour
    {
        [Header ("Character choice scene index")]
        [SerializeField]
        private int _characterChoiceSceneIndex;

        [Header("Load game scene index")]
        [SerializeField]
        private int _loadGameSceneIndex;

        [Header("Preferences scene index")]
        [SerializeField]
        private int _preferencesSceneIndex;

        [SerializeField]
        private SceneFaderScript _sceneFader;

        public void NewGame()
        {
            _sceneFader.FadeTo(_characterChoiceSceneIndex);
        }

        public void LoadGame()
        {
            _sceneFader.FadeTo(_loadGameSceneIndex);
        }

        public void Preferences()
        {
            _sceneFader.FadeTo(_preferencesSceneIndex);
        }

        public void Quit()
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
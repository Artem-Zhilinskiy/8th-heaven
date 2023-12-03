using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EightHeaven
{
    public class GlowScript : MonoBehaviour
    {
        [SerializeField]
        private Image _glowSprite;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PulsateGlow()
        {
            Color _color = _glowSprite.color;
            _color.a = 0f;
            _glowSprite.color = _color;
            Debug.Log("Button is triggered");
        }

        private void OnMouseEnter()
        {
            Debug.Log("On Mouse Enter");
        }
    }
}

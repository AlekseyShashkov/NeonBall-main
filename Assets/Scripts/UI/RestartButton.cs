using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI
{
    public class RestartButton : MonoBehaviour
    {
        public UnityEvent OnRestart = new();

        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnRestart.Invoke);
        }
    }
}

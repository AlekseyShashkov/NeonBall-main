using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class WinCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;
        public void Show()
        {
            winPanel.SetActive(true);
        }
    }
}
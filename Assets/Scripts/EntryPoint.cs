using Finish;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEngine;
using Player;

namespace EntryPoint
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private FinishPanel finishPanel;  
        [SerializeField] private WinCanvas winCanvas;
        [SerializeField] private RestartButton restartButton;
        [SerializeField] private FallRestore fallRestore;

        private void Awake()
        {
            finishPanel.FinishedEvent.AddListener(() => winCanvas.Show());
            restartButton.OnRestart.AddListener(() => 
                fallRestore.ResetState()
                );
        }
    }
}

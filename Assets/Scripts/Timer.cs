using System;
using System.Globalization;
using UnityEngine;
using TMPro;

namespace DefaultNamespace
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] public float time;
        [SerializeField] private float currentTime = 0;
        [SerializeField] private bool isTime = false;

        [SerializeField] private TextMeshProUGUI timerText;
        public WinController winController;

        private void Start()
        {
            timerText.text = time.ToString(CultureInfo.InvariantCulture);
            isTime = true;
            winController.OnEnd += EndTimer;
        }

        private void Update()
        {
            if (!isTime) return;
            currentTime += Time.deltaTime;
            DisplayTime(currentTime);
        }
        
        private void DisplayTime(float cTime)
        {
            int minutes = Mathf.FloorToInt(cTime / 60);
            int seconds = Mathf.FloorToInt(cTime % 60);
            
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
        private void EndTimer()
        {
            time = currentTime;
            isTime = false;
        }
    }
}
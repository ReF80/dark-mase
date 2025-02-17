using System;
using System.Globalization;
using UnityEngine;
using TMPro;

namespace DefaultNamespace
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] public float time = 0;
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
            timerText.text = ((int)Time.deltaTime / 60 + ":" + (int)Time.deltaTime % 60).ToString(CultureInfo.InvariantCulture);
        }

        private void EndTimer()
        {
            time = Time.deltaTime;
            isTime = false;
        }
    }
}
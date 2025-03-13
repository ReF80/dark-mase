using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class WinController : MonoBehaviour
    {
        [SerializeField] private GameObject panel;
        public GameRating gameRating;
        public GameObject end;
        public event Action OnWin;
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IAlive alive) && end == null)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
                OnWin?.Invoke();
                gameRating.CalculationRating();
            }
            else
            {
                end.SetActive(true);
            }
        }
    }
}
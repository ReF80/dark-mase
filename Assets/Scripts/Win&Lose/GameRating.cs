using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class GameRating : MonoBehaviour
    {
        [SerializeField] private Image[] star;
        [SerializeField] private Text score;
        public Player player;
        public Timer timer;

        public void CalculationRating()
        {
            score.text = (Mathf.RoundToInt(1000 - timer.time) * 1000 + player.collectItems * 10).ToString();
            
            if (player.collectItems == 3 && timer.time < 60)
            {
                ShowStars(3);
                return;
            }
            if (player.collectItems > 0 && timer.time < 70)
            {
                ShowStars(2);
                return;
            }
            ShowStars(1);
        }

        private void ShowStars(int count)
        {
            for (int i = 0; i < count; i++)
            {
                star[i].color = Color.yellow;
            }
        }
    }
}
using UnityEngine;

namespace DefaultNamespace
{
    public class GameRating : MonoBehaviour
    {
        public Player player;
        public WinController winController;

        public void CalculationRating()
        {
            //3 stars if 3 collect items and time < 1 min
            //2 stars if collect items > 1 and time < 1 min 10 sec
            //1 star if collect items - 0 and time > 1 min 10 sec
        }
        
    }
}
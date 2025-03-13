using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class OpenDoor : MonoBehaviour
    {
        [SerializeField] private Vector2[] pathPoints;
        private const float Speed = 0.01f;
        private int _posIndex;
        
        public void StartOpen()
        {
            if (pathPoints.Length <= 0) return;
            transform.position = pathPoints[0];
            StartCoroutine(Move());
        }

        private IEnumerator Move()
        {
            while (true)
            {
                if (_posIndex < pathPoints.Length)
                {
                    transform.position =
                        Vector2.MoveTowards(transform.position, pathPoints[_posIndex], Speed * Time.deltaTime);
                    if ((Vector2)transform.position == pathPoints[_posIndex])
                    {
                        _posIndex++;
                    }
                }
                else yield break;
                yield return null;
            }
        }
    }
}
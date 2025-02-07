using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class WinController : MonoBehaviour
    {
        [SerializeField] private GameObject panel;
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IAlive alive))
            {
                panel.SetActive(true);
            }
        }
    }
}
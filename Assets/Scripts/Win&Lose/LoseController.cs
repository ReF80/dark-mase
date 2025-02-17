using System;
using DefaultNamespace;
using UnityEngine;

public class LoseController : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IAlive alive))
        {
            alive.Dead();
            panelLose.SetActive(true);
        }
    }
}

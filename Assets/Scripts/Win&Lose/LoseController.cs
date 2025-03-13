using System;
using DefaultNamespace;
using UnityEngine;

public class LoseController : MonoBehaviour
{
    [SerializeField] private GameObject panelLose;
    public AudioController audioController;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IAlive alive))
        {
            alive.Dead();
            Time.timeScale = 0;
            audioController.Lose();
            panelLose.SetActive(true);
        }
    }
}

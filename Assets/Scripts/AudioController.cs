using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class AudioController : MonoBehaviour
    {
        [SerializeField] private AudioSource music;
        [SerializeField] private AudioSource winAudio;
        [SerializeField] private AudioSource loseAudio;
        
        public WinController winController;
        //public event Action OnWin; 
        //public event Action OnLose; 
        private void Start()
        {
            music.Play();
            winController.OnWin += Win;
        }

        public void Lose()
        {
            music.Stop();
            loseAudio.Play();
        }
        
        private void Win()
        {
            music.Stop();
            winAudio.Play();
        }
    }
}
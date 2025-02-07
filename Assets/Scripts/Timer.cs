using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] public float time = 0;
        [SerializeField] private bool stratTime = false;

        [SerializeField] private TextMeshProUGUI textMeshProUGUI;
        
        
    }
}
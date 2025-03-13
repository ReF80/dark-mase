using DefaultNamespace;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    //[SerializeField] private GameObject door;
    public OpenDoor openDoor;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out IAlive alive))
        {
            openDoor.StartOpen();
            Destroy(gameObject);
        }
        
    }
}

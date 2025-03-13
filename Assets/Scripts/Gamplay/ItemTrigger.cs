using UnityEngine;

namespace DefaultNamespace
{
    public class ItemTrigger : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out IAlive alive))
            {
                alive.CollectItem();
                Destroy(gameObject);
            }
        }
    }
}
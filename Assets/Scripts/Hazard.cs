using EnterKratos.ScriptableObjects;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField]
    private GameEvent gameOverEvent;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            gameOverEvent.Raise();
        }
    }
}

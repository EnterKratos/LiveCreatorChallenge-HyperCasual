using EnterKratos.ScriptableObjects;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameEvent wonEvent;

    private void OnCollisionEnter(Collision collision)
    {
        wonEvent.Raise();
    }
}

using System.Collections;
using EnterKratos.ScriptableObjects;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    private Vector3 force;

    [SerializeField]
    private float debounceTime;

    [SerializeField]
    private GameEvent bounced;

    private IEnumerator _bounceCoroutine;

    public void CompositeBounce(Rigidbody rb)
    {
        if (_bounceCoroutine != null)
        {
            return;
        }

        rb.AddForce(force, ForceMode.VelocityChange);
        bounced.Raise();
        _bounceCoroutine = Bounce();
        StartCoroutine(_bounceCoroutine);
    }

    private IEnumerator Bounce()
    {
        yield return new WaitForSeconds(debounceTime);
        _bounceCoroutine = null;
    }
}

using System.Collections;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    private Vector3 force;

    [SerializeField]
    private float debounceTime;

    private IEnumerator _bounceCoroutine;

    public void CompositeBounce(Rigidbody rb)
    {
        if (_bounceCoroutine != null)
        {
            return;
        }

        rb.AddForce(force, ForceMode.VelocityChange);
        _bounceCoroutine = Bounce();
        StartCoroutine(_bounceCoroutine);
    }

    private IEnumerator Bounce()
    {
        yield return new WaitForSeconds(debounceTime);
        _bounceCoroutine = null;
    }
}

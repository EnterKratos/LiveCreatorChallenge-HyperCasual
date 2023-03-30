using TMPro;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI bounceCountLabel;

    private int _count = 0;

    public void Increment()
    {
        _count++;
        bounceCountLabel.text = _count.ToString();
    }
}

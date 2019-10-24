using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Delete : MonoBehaviour
{

    void OnBecameInvisible()
    {
        if (this.gameObject.tag == "CoinTag")
        {
            Destroy(this.gameObject);
        }

        if (this.gameObject.tag == "CarTag")
        {
            Destroy(this.gameObject);
        }

        if (this.gameObject.tag == "TrafficConeTag")
        {
            Destroy(this.gameObject);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour {
    public GameObject Explosion;
    public GameObject PlayerExplosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            return;
        }

		Instantiate(Explosion, transform.position, transform.rotation);

        if (other.CompareTag("Player"))
        {
            Instantiate(PlayerExplosion, other.transform.position, other.transform.rotation);
        }

		Destroy(other.gameObject);
		Destroy(gameObject);
    }
}

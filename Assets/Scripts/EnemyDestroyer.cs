using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour {

    public AudioClip Explode;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy") 
        {

            Destroy(collision.gameObject);

            // AudioSource audioClip = GetComponent<AudioSource>();
            // audioClip.PlayOneShot(Explode);

        }
    }
}

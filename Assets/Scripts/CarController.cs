using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

    public float carSpeed;
    public uiManager ui;
    public AudioClip explode;

    private float minPosition = -2.4f;
    private float maxPosition = 2.5f;
    private float touchDeltaPosition;

    Vector3 position;

    public Renderer rend;

    public Transform explosion;


    // Use this for initialization
    void Start () 
    {
        
        position = transform.position;

        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.touchCount > 0 )
        {
            //Add control for android
            position.x += Input.touches[0].deltaPosition.x * carSpeed * Time.deltaTime;
            
        }
        else
        {
            position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        }

        position.x = Mathf.Clamp(position.x, minPosition, maxPosition);

        transform.position = position;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy") 
        {




            AudioSource audio = GetComponent<AudioSource>();

            // audio.PlayOneShot(explode);

            audio.Play();

            rend.enabled = false;
            Destroy(gameObject, audio.clip.length);


            var Exp = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);


            ui.ActivateGameOver();

        }
        
    }
}

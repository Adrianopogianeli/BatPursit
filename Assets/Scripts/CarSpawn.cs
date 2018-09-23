using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour {

    public GameObject[] cars;
    public float delayTimer = 1.5f;

    private float minPosition = -2.4f;
    private float maxPosition = 2.5f;

    float timer;
    int carNumber;

	// Use this for initialization
	void Start () {

        timer = delayTimer;
		
	}

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0) {

            Vector3 carPosition = new Vector3(Random.Range(minPosition, maxPosition), transform.position.y, transform.position.z);

            carNumber = Random.Range(0, 4);

            Instantiate(cars[carNumber], carPosition, transform.rotation);

            timer = delayTimer;
        }
	}
}

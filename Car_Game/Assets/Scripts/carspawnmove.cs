using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawnmove : MonoBehaviour
{
    public GameObject []  cars;

    int carNo;

    public float maxpos = 2.34f;
    public float minpos = -2.4f;

    public float delaytime = 1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delaytime;
     //   Vector3 carpos = new Vector3(Random.Range(-2.4f, 2.34f),transform.position.y,transform.position.z);

      //  Instantiate(car, carpos, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer < 0)
        {

            Vector3 carpos = new Vector3(Random.Range(-2.4f, 2.34f), transform.position.y, transform.position.z);

            carNo = Random.Range(0, 3);

            Instantiate(cars[carNo], carpos, transform.rotation);
            timer = delaytime;
        }

    }
}

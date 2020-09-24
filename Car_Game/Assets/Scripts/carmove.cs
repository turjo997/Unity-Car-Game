using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour
{
    public float carspeed;
    public float maxpos = 2.34f;
    public float minpos = -2.4f;

    public uiManager ui;



    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
       // ui = GetComponent<uiManager>();
        pos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        pos.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -2.4f, 2.34f);


        transform.position = pos;



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);

            ui.gameOverAction();
        }
    }


}

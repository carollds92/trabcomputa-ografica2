using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnight : MonoBehaviour
{
    float velTransl;
    float velRot;

    // Start is called before the first frame update
    void Start()
    {
        this.velTransl = 1f;
        this.velRot = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        float translacao = Input.GetAxis("Vertical") * velTransl;
        float rotacao = Input.GetAxis("Horizontal") * velRot;
        translacao *= Time.deltaTime;
        rotacao *= Time.deltaTime;
        transform.Translate(0, 0, translacao);
        transform.Rotate(0, rotacao, 0);
    }

    void movimenta1()
    {
        velTransl *= Time.deltaTime;
        velRot *= Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, -velTransl);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, velTransl);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -velRot, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, velRot, 0);
        }
    }
}

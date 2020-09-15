using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 15f;
    public float zen = 0.05f;
    //private Vector3 playerpos;

    //private void Start()
    //{
    //    playerpos = transform.position;
    //}

    private void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        this.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z + zen);
    }

    private void FixedUpdate()
    {
        var velox = speed * Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3(velox, 0f, 0f);
        //transform.position = new Vector3(playerpos.x , playerpos.y, playerpos.z + 10.0f);
    }
}

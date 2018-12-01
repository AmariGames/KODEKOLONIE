using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {
    public float speed;
    public Rigidbody2D rb2d;
    Vector2 pos;
    void Awake()
    {
        rePos();
    }
    void FixedUpdate()
    {
        /*
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);
        */
        if (Input.GetMouseButton(0)) pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //if ((Mathf.Abs(pos.x - transform.position.x) < 5) && (Mathf.Abs(pos.y - transform.position.y) < 5)) rePos();
            //transform.position = new Vector3(pos.x,pos.y,transform.position.z);
        /* 
         float angle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
         Quaternion rotate = Quaternion.AngleAxis(angle, Vector3.forward);
         transform.rotation = Quaternion.Slerp(transform.rotation, rotate, 5f * Time.deltaTime);
         */

        Vector2 rotate = new Vector2(pos.x - transform.position.x, pos.y - transform.position.y);
        transform.up = rotate;
        transform.position += transform.up * speed * Time.deltaTime;
        

      //  transform.position += new Vector3(((pos.x - transform.position.x) * speed * Time.deltaTime ), ((pos.y - transform.position.y) * speed * Time.deltaTime), 0);
      
    }
    void rePos()
    {
        pos = transform.position;
    }
}

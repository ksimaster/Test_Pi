using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutScript : MonoBehaviour
{
    public GameObject projectile;
    public GameObject clone;
    public string collisionTag;
    public GameObject smallSquare;
  /*  void Update()
    {
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
                clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
        }

    }
  
    */
 

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag(collisionTag))
        {
            //if(!smallSquare.activeSelf)
            Debug.Log("Коллизия случилась :)");
            smallSquare.SetActive(false);
            /*
            if (smallSquare.activeSelf)
                smallSquare.SetActive(false);
                */
        }

    }


}

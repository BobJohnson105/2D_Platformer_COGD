using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
            //bullet.GetComponent<Rigidbody2D>().AddForce(new Vector3(projectileSpeed * transform.localScale.x, 0, 0), ForceMode2D.Impulse);
            //Get the position of this object in screen-coordinates
            Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);

            //You can calculate the direction from point A to point B using Vector3 dirAtoB = B - A;
            Vector3 dirToMouse = Input.mousePosition - posInScreen;

            //We normalize the direction (= make length of 1). This is to avoid the object moving with greater force when I click further away
            dirToMouse.Normalize();

            //Adding the force to the 2D Rigidbody, multiplied by forceAmount, which can be set in the Inspector
            GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(dirToMouse * projectileSpeed, ForceMode2D.Impulse);
        }
    }
  
}


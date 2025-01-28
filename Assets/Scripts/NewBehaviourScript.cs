using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float rotationSpeed;
    public Transform gun;
    public GameObject bullet;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, h * rotationSpeed * Time.deltaTime, 0);

        float v = Input.GetAxisRaw("Vertical");
        gun.transform.Rotate(v * rotationSpeed * Time.deltaTime, 0, 0);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bullet, gun.position, Quaternion.identity);
            Rigidbody rb = b.GetComponent<Rigidbody>();
            rb.AddForce(gun.transform.up * bulletSpeed, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomComponent : MonoBehaviour
{
    Rigidbody rb;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);

            //Lets the sphere shoot up!
            //rb.AddForce(Vector3.up * 500);
        }
        //moves sphere forward
        //rb.velocity = Vector3.forward * 20f;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("level2");
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jeremy") ;
        {
            Destroy(gameObject);
        }
        winText.SetActive(true);
    }
}

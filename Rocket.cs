using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    Rigidbody _rigidbody;
    
    AudioSource _sound;
    bool _isPlaying;

    // Use this for initialization
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _sound = GetComponent<AudioSource>();
        


    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

    }
    public void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddRelativeForce(Vector3.up * 10);
            
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward*10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward*10);
        }
        if (Input.GetKey(KeyCode.O))
        {

            SceneManager.LoadScene("Rockets");
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere"
            || col.gameObject.name == "Sphere(1)" || col.gameObject.name == "Sphere(2)"
            || col.gameObject.name == "Sphere(3)" || col.gameObject.name == "Sphere(4)")
        {
            SceneManager.LoadScene("Rockets");
        }
        if (col.gameObject.name == "Target Pad")
        {
            SceneManager.LoadScene("rscene2");
        }
        

    }
    }



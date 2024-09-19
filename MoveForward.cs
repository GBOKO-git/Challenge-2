using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{ 
    // variable speed pour acceler le mouvement de food
    public float speed = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Appel de la fonction qui permet le deplacement de food
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

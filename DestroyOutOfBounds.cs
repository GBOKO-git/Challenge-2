using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // varible pour detruire foods en dehors de l'espace de jeu
    private float topBound = 30;
    // variable pour detruire les animaux
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // condition pour detruire food
        if (transform.position.z > topBound)
        {
                    Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
                  {Destroy(gameObject);} // instruction pour detruire les animaux
        // Afficher du texte 
        Debug.Log("Game over!");        
    }
}

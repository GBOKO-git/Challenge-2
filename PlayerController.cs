using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //declaration de la variable horizontalInput pour bouger le "player"
    public float horizontalInput;

    // Declaration de la variable speed pour accellerer les mouvement de "player"
    public float speed = 10.0f;
    
    // Declaration de variable pour modifier la condition -10 de if
    public float xRange = 10;

    // Declaration de la var GameObject pour inclure l'element du prefabs
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            // condition pour  le "player" à ne pas depasser la gauche de la zone de jeu
            if(transform.position.x < -xRange)
            {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

        // condition pour  le "player" à ne pas depasser la droite de la zone de jeu
             if(transform.position.x > xRange)
            {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }

    // condition pour  le "player" à utiliser le bouton "espace"
   if (Input.GetKeyDown(KeyCode.S))
    {
        // instruction pour lancer les foods
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }


        // Assignation de la variable horizontalInput à utiliser les fonctionnalité de la fonction Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        // Deplacer le "player" de gauche à droite
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Implement universal pet script for all pets, call member functions via pet manager. Pet manager does different things depending on scene.
public class PetManager : MonoBehaviour
{
    List<GameObject> pets = new List<GameObject>();
    List<GameObject> availablePets = new List<GameObject>();
    public GameObject pet1;
    public Pet1 Pet1Script;

    // Start is called before the first frame update
    void Start()
    {
        pets.Add(pet1);
        availablePets.Add(pet1);

        if (SceneManager.GetActiveScene().name == "Pet Menu")
        {
            foreach (GameObject pet in availablePets)
            {
                pet.GetComponent<Pet1>().DisplayInfo();
                pet.GetComponent<Pet1>().DisplayName();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public AudioClip clip;
    public AudioSource audioSource;
    [SerializeField] private Collider otherCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other == otherCollider)
            audioSource.PlayOneShot(clip);
    }
}

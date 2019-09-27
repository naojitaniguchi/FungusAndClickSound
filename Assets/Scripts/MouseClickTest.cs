using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickTest : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("hoge");
            audioSource.PlayOneShot(clips[Random.Range(0, clips.Length)]);
        }
    }
}

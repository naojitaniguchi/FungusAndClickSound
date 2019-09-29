using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickAndAetSprite : MonoBehaviour
{
    public AudioClip[] clips;
    public GameObject[] sprites;
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
            int index = Random.Range(0, clips.Length);

            audioSource.PlayOneShot(clips[index]);

            Vector3 touchScreenPosition = Input.mousePosition;
            touchScreenPosition.z = 10.0f;
            Camera gameCamera = Camera.main;
            Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);
            Instantiate(sprites[index], touchWorldPosition, Quaternion.identity);
        }

    }
}

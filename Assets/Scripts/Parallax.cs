using UnityEngine;

public class Parallax : MonoBehaviour
{
    [Range(0f,1f)]
    public float parallaxFactor = 0.2f;

    private Transform cam;
    private Vector3 lastCamPosition;

    private float spriteWidth;

    void Start()
    {
        cam = Camera.main.transform;
        lastCamPosition = cam.position;

        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        Vector3 delta = cam.position - lastCamPosition;

        // Parallax movement
        transform.position += new Vector3(delta.x * parallaxFactor, 0f, 0f);

        lastCamPosition = cam.position;

        // Infinite background loop
        if (Mathf.Abs(cam.position.x - transform.position.x) >= spriteWidth)
        {
            float offset = (cam.position.x - transform.position.x) % spriteWidth;
            transform.position = new Vector3(cam.position.x + offset, transform.position.y, transform.position.z);
        }
    }
}
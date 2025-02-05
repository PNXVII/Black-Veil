using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParallaxHandler : MonoBehaviour
{
    public Camera cam;
    public Transform followTraget;

    private Vector2 startingPosition;

    private float startingZ;

    private Vector2 camMoveSinceStart => (Vector2)cam.transform.position - startingPosition;

    [Range(0.01f, 0.99f)]
    public float parallaxFactor = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        startingZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = (startingPosition + camMoveSinceStart * (-parallaxFactor));

        transform.position = new Vector3(newPosition.x, newPosition.y, startingZ);
    }
}

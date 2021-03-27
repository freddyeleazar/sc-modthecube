using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 direction;
    public float translationSpeed;
    public float scale;
    public Vector3 angle;
    public float rotationSpeed;
    public Color color;

    private MeshRenderer Renderer;

    void Start()
    {
        Renderer = GetComponent<MeshRenderer>();

        //Modify any of the changes above so they change randomly each time the scene is played.
        direction = new Vector3(Random.value, Random.value);
        angle = new Vector3(Random.value, Random.value, Random.value);
    }

    void Update()
    {
        //Change the cube's location (transform)
        Translate(direction, translationSpeed);

        //Change the cube's scale
        Scale(scale);

        //Change the angle at which the cube rotates
        //Change the cube’s rotation speed
        Rotate(angle, rotationSpeed);

        //Change the cube’s material color
        //Change the cube’s material opacity
        //Add extra functionality to the cube. For example, how might you change the color of the cube over time?
        color = new Color(transform.position.normalized.x, transform.position.normalized.y, transform.position.normalized.z);
        Colorize(color);
    }
    private void Translate(Vector3 direction, float translationSpeed)
    {
        transform.Translate(direction.normalized * translationSpeed * Time.deltaTime);
    }
    private void Scale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    private void Rotate(Vector3 angle, float speed)
    {
        transform.Rotate(angle.normalized * speed * Time.deltaTime);
    }

    private void Colorize(Color color)
    {
        Renderer.material.color = color;
    }
}

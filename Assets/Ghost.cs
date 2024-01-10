using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public float speed = 0.7f;
    public float duration = 3f; // laikas po kurio veikejas prades judeti i kita puse

    private float timer = 0f;
    private bool moveRight = true;

    void Update()
    {
        timer += Time.deltaTime;

        // Objekto judejimas
        if (moveRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        
        if (timer >= duration)
        {
            moveRight = !moveRight;
            timer = 0f; //resetiname timeri
        }
    }
}

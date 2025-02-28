using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CaveMovement : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    private float _xDirection;
    private float _yDirection;
    public Collider2D col;
    public Rigidbody2D rd;
    public  Scene scene;

    void Start()
    {                                                                                                 
        xSpeed = 4;
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Overworld")
        {
            ySpeed = 4;
        }
        else
        {
            ySpeed = 0;}
        col = GetComponent<Collider2D>();
        rd = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        

        _xDirection = Input.GetAxis("Horizontal");
        _yDirection = Input.GetAxis("Vertical");
        float xVector = _xDirection * xSpeed * Time.deltaTime;
        float yVector = _yDirection * ySpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, 0);
        RaycastHit2D h =
       Physics2D.Raycast(transform.position, Vector2.down);
        if (h.distance < col.bounds.extents.y)
        {

            if (Input.GetKeyDown(KeyCode.Space) && ySpeed == 0)
            {
                rd.AddForce(new Vector2(0f, 10f));
            }
        }
    }
}

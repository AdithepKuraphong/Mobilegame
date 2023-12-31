using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rg;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(touchPos);
            if (touchPos.x < 0)
            { rg.AddForce(Vector2.left * moveSpeed); }
            else
            { rg.AddForce(Vector2.right * moveSpeed); }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Block")
        {
            SceneManager.LoadScene(0);
        }
    }
}

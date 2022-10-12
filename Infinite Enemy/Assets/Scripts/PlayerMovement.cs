using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D _rgbdP;
    public float _speed = 5f;
    private Vector2 _direction;

    GameObject _stopInstantiate;

    // Start is called before the first frame update
    void Start()
    {
        _stopInstantiate = GameObject.Find("Enemy instantiation");
    }

    // Update is called once per frame
    void Update()
    {

        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        _rgbdP.velocity = _direction.normalized * _speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            _stopInstantiate.SetActive(false);
        }
    }
}

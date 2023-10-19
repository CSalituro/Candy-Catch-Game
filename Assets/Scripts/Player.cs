using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _moveDir;

   // private Rigidbody2D _rb;
    private float _depth;

    void Start()
    {
        Manager.Init(this);
        Manager.GameMode();

      //  _rb = GetComponent<Rigidbody2D>();
        _depth = GetComponent<Collider2D>().bounds.size.y;
    }

    public void SetMovementDirection(Vector3 newDirection)
    {
        _moveDir = newDirection;
    }
    
    
}

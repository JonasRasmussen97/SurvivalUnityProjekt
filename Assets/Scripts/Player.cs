using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 target;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        animator.SetBool("isMoving", true);
        }
        
        transform.position = Vector2.MoveTowards(this.transform.position, target, 0.02f);
        
        }

    }


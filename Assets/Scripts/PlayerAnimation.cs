using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public static readonly string[] staticDirections = {"Idle N", "Idle NW", "Idle W",
    "Idle SW", "Idle S", "Idle SE", "Idle E", "Idle NE"};

    public static readonly string[] runDirections = {"Run N", "Run NW", "Run W",
    "Run SW", "Run S", "Run SE", "Run E", "Run NE"};

    Animator animator;
    int lastDirection;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void SetDirection(Vector2 direction)
    {
        string[] directionsArray = null;
        if (direction.magnitude < 0.01f)
        {
            directionsArray = staticDirections;
        }
        else
        {
            directionsArray = runDirections;
            lastDirection = DirectionToIndex(direction);
        }
        animator.Play(directionsArray[lastDirection]);
    }
    public int DirectionToIndex(Vector2 direction)
    {
        Vector2 norDir = direction.normalized;
        float step = 360 / 8;
        float offset = step / 2;

        float angle = Vector2.SignedAngle(Vector2.up, norDir);
        angle += offset;
        if(angle < 0)
        {
            angle += 360;
        }
        float stepCount = angle / step;
        return Mathf.FloorToInt(stepCount);
    }


}



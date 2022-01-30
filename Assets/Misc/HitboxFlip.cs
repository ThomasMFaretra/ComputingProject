using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFlip : MonoBehaviour
{
    public Vector2 rightPosition;
    public Vector2 leftPosition;
    private Position pos;

    void Start()
    {
        pos = GetComponentInParent<Position>();
        transform.localPosition = rightPosition;
    }

    void Update()
    {
        if (pos.lastDirection == 1f)
        {
            transform.localPosition = rightPosition;
        }
        if (pos.lastDirection == -1f)
        {
            transform.localPosition = leftPosition;
        }
    }
}

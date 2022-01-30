using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTo : MonoBehaviour
{
    private Switch ch;
    private CooldownControl cc;
    public Transform point;
    private Rigidbody2D rb;

    public float maxMagnitude;
    public float magnitude;
    private float currentMagnitude;

    public float endLag;
    public float moveCooldown;
    private float cooldown;
    
    public float smoothTime;
    public float minimumDistance;
    public float initialBack;
    
    private float distance;
    private float degrees;
    private bool start;

    private ControlScheme controls;

    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ch = GetComponent<Switch>();
        cc = GetComponent<CooldownControl>();
        magnitude = -initialBack;
    }

    void Update()
    {
        Cooldown();
        Distance();
        if ((controls.Main.UpSpecial.ReadValue<float>() == 1f && ch.character == 2f && cooldown <= 0f && cc.canUse == true) ^ start == true)
        {
            Fly();
        }
        if (controls.Main.DownSpecial.ReadValue<float>() == 1f)
        {
            Pointer();
        }


    }

    void Fly()
    {
        if (start == false)
        {
            cc.countdownTime += endLag;
        }
        
        if (distance > minimumDistance && controls.Main.Jump.ReadValue<float>() == 0f)
        {
            start = true; //keeps the script running
            cc.countdownTime = cc.canUseTime += Time.deltaTime; //puts the movement on cooldown
            magnitude = Mathf.SmoothDamp(magnitude, maxMagnitude, ref currentMagnitude, smoothTime, Mathf.Infinity, Time.deltaTime);
            rb.velocity = new Vector2(magnitude * Mathf.Cos((degrees)), magnitude * Mathf.Sin((degrees)));
        }
        else
        {
            start = false;
            cooldown += moveCooldown;
            currentMagnitude = 0;
            magnitude = -initialBack;
        }
    }

    void Pointer()
    {
        
    }

    void Cooldown()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }

    void Distance()
    {
        float x = (point.position.x - rb.position.x);
        float y = (point.position.y - rb.position.y);
        degrees = Mathf.Atan2(y, x);
        distance = Mathf.Sqrt(x * x + y * y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject sphere;
    private GameObject newSphere;
    public bool isActive = false;
    private Switch ch;
    private CooldownControl cc;
    public Transform point;
    private Rigidbody2D rb;

    public float startLag;
    private float startTimer;
    public float abilitiesCooldown;
    public float moveCooldown;
    private float cooldown;
    public float placeCooldown;
    private float placeCooldownTimer;


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
        startTimer = startLag;
    }

    void Cooldown()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
        if (placeCooldownTimer > 0)
        {
            placeCooldownTimer -= Time.deltaTime;
        }
    }

    void Update()
    {
        Cooldown();
        if ((controls.Main.UpSpecial.ReadValue<float>() == 1f && ch.character == 2f && cooldown <= 0f && cc.canUse == true && isActive == true) ^ start == true)
        {
            Tele();
        }
        if ((controls.Main.DownSpecial.ReadValue<float>() == 1f && ch.character == 2f && placeCooldownTimer <= 0f))
        {
            Placement();
        }
    }

    void Placement()
    {
        if (isActive == false)
        {
            newSphere = Instantiate(sphere);
            newSphere.transform.position = rb.position;
            placeCooldownTimer = placeCooldown;
            isActive = true;

        }
        else
        {
            Destroyer();
        }
    }

    void Destroyer()
    {
        Destroy(newSphere);
        placeCooldownTimer = placeCooldown;
        isActive = false;
    }

    void Tele()
    {
        if (start == false)
        {
            cc.canUseTime = abilitiesCooldown;
            start = true;
        }
        if (startTimer > 0)
        {
            startTimer -= Time.deltaTime;
        }
        else
        {
            rb.position = newSphere.transform.position;
            start = false;
            cooldown += moveCooldown;
            Destroyer();
        }
    }
}
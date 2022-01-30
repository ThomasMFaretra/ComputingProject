using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public float character = 0;
    public float girlGravityScale;
    public float regularGravityScale;
    private Animator ani;
    private CooldownControl cc;

    public float cooldown;
    private float cooldownTime = 0f;

    private ControlScheme controls;

    void Awake()
    {
        controls = new ControlScheme();
        controls.Main.Enable();
    }

    void Start()
    {
        cc = GetComponent<CooldownControl>();
        ani = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (cooldownTime > 0)
        {
            cooldownTime -= Time.deltaTime;
        }

        if (cc.canUse == true)
        {
            if (controls.Main.Switch.ReadValue<float>() == 1 && cooldownTime <= 0)
            {
                character += 2;
                character = character % 3;
                cooldownTime = cooldown;
                SwitchAnimation();
            }
            if (controls.Main.Switch.ReadValue<float>() == -1 && cooldownTime <= 0)
            {
                character += 1;
                character = character % 3;
                cooldownTime = cooldown;
                SwitchAnimation();
            }
            if (character == 2)
            {
                cc.gravityScale = girlGravityScale;
            }
            else
            {
                cc.gravityScale = regularGravityScale;
            }
        }
        
    }

    private void SwitchAnimation()
    {
        if (character == 2) 
        {
            ani.Play("Girl_Idle");
        }
        if (character == 1)
        {
            ani.Play("Boy_Idle");
        }
        if (character == 0)
        {
            ani.Play("Maid_Idle");
        }
    }
}

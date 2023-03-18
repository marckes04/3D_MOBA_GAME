using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimation : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool walk)
    {
        anim.SetBool(AnimationClass.WALK_PARAMETER,walk);
    }

    public void Run(bool run)
    {
        anim.SetBool(AnimationClass.RUN_PARAMETER,run);
    }

    public void NormalAttack_1()
    {
        anim.SetTrigger(AnimationClass.NORMAL_ATTACK_1_TRIGGER);
    }

    public void NormalAttack_2()
    {
        anim.SetTrigger(AnimationClass.NORMAL_ATTACK_2_TRIGGER);
    }

    public void SpecialAttack_1()
    {
        anim.SetTrigger(AnimationClass.SPECIAL_ATTACK_1_TRIGGER);
    }

    public void SpecialAttack_2()
    {
        anim.SetTrigger(AnimationClass.SPECIAL_ATTACK_2_TRIGGER);
    }

    public void SpecialAttack_3()
    {
        anim.SetTrigger(AnimationClass.SPECIAL_ATTACK_3_TRIGGER);
    }

    public void Hit()
    {
        anim.SetTrigger(AnimationClass.HIT_TRIGGER);
    }

    public void Dead()
    {
        anim.SetTrigger(AnimationClass.DEAD_TRIGGER);
    }
}

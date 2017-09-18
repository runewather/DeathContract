using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {

    private Animator anim;

    [SerializeField]
    private WeaponScript scythe;

    public void EnableAttack()
    {
        scythe.EnableAttack();
    }

    public void DisableAttack()
    {
        scythe.DisableAttack();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	void Update ()
    {
		if(Input.GetButtonDown("Attack"))
        {
            anim.SetTrigger("Attack");
        }
	}
}

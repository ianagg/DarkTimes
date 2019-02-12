using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUpText : MonoBehaviour {

    public Animator anim;
    private Text damage;


    private void Awake()
    {
        AnimatorClipInfo[] animInfo = anim.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, animInfo[0].clip.length);
        damage = anim.GetComponent<Text>();

    }

    public void SetDamage(string text) {

        damage.text = text;
    }


}
    
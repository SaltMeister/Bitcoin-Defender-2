using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
	private int hp;
	public Text hpText;

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        hpText.text = hp.ToString();
        Debug.Log(hp);
        Debug.Log(hpText);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          //TakeDamage(10);
        }
    }
}
/*
    void TakeDamage(int dmg)
    {
    	hp = dmg;
    	hpText.text = hp.toString();
    }
*/
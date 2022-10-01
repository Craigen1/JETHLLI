using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class S2GameHandler : MonoBehaviour
{
    public GameObject p2Health;
    public int player2HP = 100;
    public VideoClip v1;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p2Health.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = player2HP + "";
    }
     void dealDamage(int damageAmount, int playerHP){
            playerHP -= damageAmount;
            player2HP = playerHP;
    }

    void attack(float accuracy, IEnumerator attackname, VideoClip video){
        int x = Random.Range(1, 101);

        if(x <= accuracy){
            StartCoroutine(attackname);
            Debug.Log("Attack Success!");
        }
        else{
            Debug.Log("Attack Missed!");
        }
    }
    
    void p1Lowpunch(){
        attack(95, p1Lowpunchdelay(), v1);
        dealDamage(5, player2HP);
    }
     IEnumerator p1Lowpunchdelay(){
        yield return new WaitForSeconds(2F);
    }
}

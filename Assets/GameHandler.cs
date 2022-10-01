using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public GameObject p2Health, VideoPlayerGO;
    public int player2HP = 100;
    
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

    void attack(float accuracy, IEnumerator attackname){
        int x = Random.Range(1, 101);

        if(x <= accuracy){
            StartCoroutine(attackname);
            Debug.Log("Attack Success!");
        }
        else{
            Debug.Log("Attack Missed!");
        }
    }
    
    public void p1Lowpunch(){
    }
    public void ChangeScene(){
        SceneManager.LoadScene("S3");
        }
     IEnumerator p1Lowpunchdelay(){
        yield return new WaitForSeconds(2F);
        SceneManager.LoadScene("S3");
     }
}


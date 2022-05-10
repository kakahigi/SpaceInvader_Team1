using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPort : MonoBehaviour
{
    [SerializeField] GameObject NormalEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, 4f); //GenerateEnemyŠÖ”‚ğ4•b‚Éˆê“xŒÄ‚Ño‚·‚æ
    }

    //“G‚ğ¶¬‚·‚éŠÖ”
    void GenerateEnemy()
    {
        GameObject enemy = Instantiate(NormalEnemy);  //“G‚ğ¶¬
        enemy.transform.position = this.transform.position; //¶¬‚µ‚½“G‚ÌˆÊ’u‚ğA‚±‚ÌEnemyPort‚ÌˆÊ’u‚É’²®
    }
}

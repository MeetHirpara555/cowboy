using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hero : MonoBehaviour
{
    Rigidbody2D rb;
    float speed ;
    float jump = 8.3f;
    Animator animator;
    bool walk,jumpani,hurtani;
    int lifeCount,coinCollect,mode;
    public GameObject h,h1,h2;
    float Tt;
    public coinmusic cm;
    // Start is called before the first frame update
    void Start()
    {

        mode = PlayerPrefs.GetInt("mode");
        if(mode == 0)
        {
            speed = 6f;
        }
        if(mode == 1)
        {
            speed = 8f;
        }
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        walk = true;
        jumpani = false;
        
        PlayerPrefs.SetInt("LC", 3);
        lifeCount = PlayerPrefs.GetInt("LC");
        Tt = 0;
        PlayerPrefs.SetInt("CC", 0);
        coinCollect = PlayerPrefs.GetInt("CC");
        
    }

    // Update is called once per frame
    void Update()
    {
        Tt += Time.deltaTime;
        PlayerPrefs.SetFloat("TT",Tt);
        if (walk)
        {
            animator.SetTrigger("iswalk");
        }
        rb.velocity = new Vector2(speed, rb.velocity.y);
        if (jumpani)
        {
            animator.SetTrigger("isjump");
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            walk = false;
            jumpani = true;
            rb.velocity = new Vector2(rb.velocity.x, jump);

        }
        lifeCount = PlayerPrefs.GetInt("LC");
        if(lifeCount == 2)
        {
            Destroy(h2);
        }
        if (lifeCount == 1)
        {
            Destroy(h1);
        }
        if(lifeCount == 0)
        {
            Destroy(h);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "surface")
        {
            walk = true;
            jumpani = false;
            hurtani = false;
        }
       
        if (collision.gameObject.tag == "box")
        {
                lifeCount = PlayerPrefs.GetInt("LC");
                lifeCount--;
                PlayerPrefs.SetInt("LC", lifeCount);
                
            if(lifeCount > 0)
            {
                Destroy(collision.gameObject);
            }
            if (lifeCount == 0)
            {
                animator.SetTrigger("isdie");
                StartCoroutine(gameover());
            }

        }
        

        if (collision.gameObject.tag == "bird")
        {
            
            lifeCount = PlayerPrefs.GetInt("LC");
            lifeCount--;
            PlayerPrefs.SetInt("LC", lifeCount);
            if (lifeCount > 0)
            {
                Destroy(collision.gameObject);
            }
            if (lifeCount == 0)
            {
                animator.SetTrigger("ishurt");
                StartCoroutine(gameover1());
            }

        }

       

    }

    
    IEnumerator gameover()
    {
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene("gameover");
    }
    IEnumerator gameover1()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("gameover");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            cm = FindObjectOfType<coinmusic>();
            cm.musicplay();
            coinCollect = PlayerPrefs.GetInt("CC");
            coinCollect++;
            PlayerPrefs.SetInt("CC", coinCollect);
            Destroy(collision.gameObject);
        }
    }




}

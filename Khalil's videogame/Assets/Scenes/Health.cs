using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int heartIndex;
    public Image[] hearts;
    public Sprite fullheart;
    public Sprite emptyheart;

    private void Start()
    {
        heartIndex = 0;
        foreach(Image item in hearts)
        {
            item.sprite = fullheart;
        }
    }

    private void Update()
    {
        
        //for (int numberofhits = 0; numberofhits < hearts.Length; numberofhits++)
        //{
        //    if (numberofhits < numberofhearts)
        //        {
        //        hearts[numberofhits].enabled = true;

        //        }else
        //    {
        //        hearts[numberofhits].enabled = false;
        //    }
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            LowerHealth();
            heartIndex++;
            if(heartIndex == hearts.Length)
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    private void LowerHealth()
    {
        hearts[heartIndex].sprite = emptyheart;
    }
}    

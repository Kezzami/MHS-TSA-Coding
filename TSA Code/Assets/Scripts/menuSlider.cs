using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuSlider : MonoBehaviour
{
    public Image menu;
    public Image button1;
    public Image button2;
    public Image button3;
    public Image button4;
    public Image button5;
    
    public void menuSlide()
    {
        if(menu.IsActive())
        {
            StartCoroutine(endSlide());
        }
        
        else if(menu.IsActive() == false)
        {
            menu.gameObject.SetActive(true);
            button1.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
            button3.gameObject.SetActive(true);
            button4.gameObject.SetActive(true);
            button5.gameObject.SetActive(true);
            StartCoroutine(startSlide());
        }
    }
    
    IEnumerator startSlide()
    {
        yield return new WaitForSeconds(0.01f);
        menu.fillAmount += 0.1f;
        button1.fillAmount += 0.1f;
        button2.fillAmount += 0.1f;
        button3.fillAmount += 0.1f;
        button4.fillAmount += 0.1f;
        button5.fillAmount += 0.1f;

        if (menu.fillAmount < 1)
        {
            StartCoroutine(startSlide());
        }
    }

    IEnumerator endSlide()
    {
        yield return new WaitForSeconds(0.01f);
        menu.fillAmount -= 0.1f;
        button1.fillAmount -= 0.1f;
        button2.fillAmount -= 0.1f;
        button3.fillAmount -= 0.1f;
        button4.fillAmount -= 0.1f;
        button5.fillAmount -= 0.1f;

        if (menu.fillAmount > 0)
        {
            StartCoroutine(endSlide());
        }

        if (menu.fillAmount == 0)
        {
            menu.gameObject.SetActive(false);
            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.gameObject.SetActive(false);
            button5.gameObject.SetActive(false);
        }
    }
}

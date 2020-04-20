using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI MyText;
    public string[] sentences;
    private int index;
    public float TextSpeed = 0.03f;
    public GameObject nextButton;

    void Start()
    {
        nextButton.SetActive(false);
        StartCoroutine(Typing());
    }

    //converte ogni carattere dell'array "sentences" in char, poi aggiunge al MyText una lettera (1 char) alla volta in base alla velocità settata in textSpeed
    IEnumerator Typing()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            MyText.text += letter;
            yield return new WaitForSeconds(TextSpeed);
        }
    }

    //da collegare al bottone, fa avanzare il testo andando a prendere le frasi successive dell'array ogni volta che una frase finisce
    public void NextSentence()
    {
        if(index < sentences.Length)
        {
            index++;
            MyText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            MyText.text = "";
        }
    }
}

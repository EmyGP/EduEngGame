using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//per caricare le scene. Mettere una copia di questo script per ogni scena e poi selezionare la scena dalla funz OnClick del button (wow...)
//per chiudere il gioco e temo anche per altro in futuro
public class SceneOpener : MonoBehaviour
{
    public string Scene_name;

    public void GotToScene()
    {
         SceneManager.LoadScene(Scene_name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

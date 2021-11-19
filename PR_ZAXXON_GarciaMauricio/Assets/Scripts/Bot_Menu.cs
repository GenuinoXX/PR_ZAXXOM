using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bot_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menu_Prin()
    {
        SceneManager.LoadScene(0);
    }
    public void Juego()
    {
        GameManager.Vidas_Jug = 3;
        SceneManager.LoadScene(1);
    }
    public void Menu_Punt()
    {
        SceneManager.LoadScene(4);
    }
    public void Menu_Opc()
    {
        SceneManager.LoadScene(3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    #region Menu inicial
    public void ComecarJogo()
    {
        SceneManager.LoadScene("Game");
    }

    public void FecharJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do jogo");
    }
    #endregion

    #region In Game
    public void Reiniciar()
    {
        SceneManager.LoadScene("Game");
    }

    public void Sair()
    {
        SceneManager.LoadScene("Menu inicial");
    }
    #endregion
}

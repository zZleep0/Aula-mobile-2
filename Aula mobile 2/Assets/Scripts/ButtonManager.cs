using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject nivelCompleto;
    [SerializeField] private SoundManager soundManager;

    #region Menu inicial
    public void ComecarJogo()
    {
        soundManager.PlaySound(SoundManager.SoundType.TypeBTN);
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
        soundManager.PlaySound(SoundManager.SoundType.TypeBTN);
        SceneManager.LoadScene("Game");
    }

    public void Sair()
    {
        soundManager.PlaySound(SoundManager.SoundType.TypeBTN);
        SceneManager.LoadScene("Menu inicial");
    }

    public void ProximoNivel()
    {
        soundManager.PlaySound(SoundManager.SoundType.TypeBTN);
        Debug.Log("Foi para o proximo");
    }

    public void Pause()
    {
        soundManager.PlaySound(SoundManager.SoundType.TypeBTN);
    }
    #endregion
}

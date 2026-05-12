using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDoJogo : MonoBehaviour
{
    public GameObject painelDoMenuInicial, painelDaTelaDeCreditos;
    public string nomeDaPrimeiraFase;
    public void CarregarJogo()
    {
        SceneManager.LoadScene(nomeDaPrimeiraFase);
    }

    public void AtivarPainelDoMenuInicial()
    {
        painelDoMenuInicial.SetActive(true);
        painelDaTelaDeCreditos.SetActive(false);
    }

    public void AtivarPainelDeCreditos()
    {
        painelDoMenuInicial.SetActive(false);
        painelDaTelaDeCreditos.SetActive(true);
    }

    
    public void SairDoJogo()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}


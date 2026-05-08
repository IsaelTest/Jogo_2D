using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nomeDaProximaFase;
    public float tempoParaRecarregarNovaFase;
    public float tempoParaRecarregarAFase;
    public void GameOver()
    {
        RodarCoroutineRecarregarFase();
    }
    public void RodarCoroutineRecarregarFase()
    {
        StartCoroutine(RecarregarFase());
    }
    private IEnumerator RecarregarFase()
    {
        yield return new WaitForSeconds(tempoParaRecarregarAFase);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RodarCoroutinePassarDeFase()
    {
        StartCoroutine(PassarDeFase());
    }

    private IEnumerator PassarDeFase()
    {        
          yield return new WaitForSeconds(tempoParaRecarregarNovaFase);
          SceneManager.LoadScene(nomeDaProximaFase);
    }
}
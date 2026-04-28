using UnityEngine;
using System.Collections;
public class VidaDoJogador : MonoBehaviour
{
    [Header("Referências")]
    public GameObject efeitoDeExplosao;
    private Rigidbody2D oRigidbody2D;
    private Animator oAnimator;

    [Header("Valores")]
    public float tempoParaDestruirOJogador;
    void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oAnimator = GetComponent<Animator>();
    }
    public void MachucarJogador()
    {
        //Método obsoleto, substituído por FindFirstObjectByType para melhorar a performance e evitar possíveis erros de referência
        //FindObjectOfType<MovimentoDoJogador>().jogadorEstaVivo = false; 
        FindFirstObjectByType<MovimentoDoJogador>().jogadorEstaVivo = false;       
        //Zerar velocidade do jogador para evitar que ele continue se movendo após ser machucado
        oRigidbody2D.linearVelocity = Vector2.zero;
        oAnimator.Play("jogador-levando-dano");

        StartCoroutine(DetruirJogador());
    }

    private IEnumerator DetruirJogador()
    {        
        yield return new WaitForSeconds(tempoParaDestruirOJogador);
        FindFirstObjectByType<GameManager>().GameOver();       
        Instantiate(efeitoDeExplosao, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}

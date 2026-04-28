using UnityEngine;

public class VerificadorDeArmadilha : MonoBehaviour
{ 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlataformaArmadilha>() != null)
        {
            if(other.gameObject.GetComponent<PlataformaArmadilha>().enabled == true)
            {
                other.gameObject.GetComponent<PlataformaArmadilha>().RodarCoroutineDesligarPlataforma();
            }
        }
    }
    
}

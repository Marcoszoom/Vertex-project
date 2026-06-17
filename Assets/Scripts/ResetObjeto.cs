using UnityEngine;

public class ResetObjeto : MonoBehaviour
{
    [Header("Arraste o Cilindro para cá:")]
    public GameObject objetoParaResetar;

    private Vector3 posInicial;
    private Quaternion rotInicial;
    private Rigidbody rb;

    void Start()
    {
        if (objetoParaResetar != null)
        {
            // Guarda a posição e rotação perfeitas do início do jogo
            posInicial = objetoParaResetar.transform.position;
            rotInicial = objetoParaResetar.transform.rotation;

            // Pega a física do objeto automaticamente
            rb = objetoParaResetar.GetComponent<Rigidbody>();
        }
    }

    public void ResetarPosicao()
    {
        // TEXTO DE DIAGNÓSTICO AUTOMÁTICO:
        // Olhe no seu Console quando clicar no botão!
        Debug.Log("O BOTÃO FOI CLICADO COM SUCESSO! O script recebeu o comando.");

        if (objetoParaResetar != null)
        {
            // Se o cilindro tiver física, usa o MovePosition para não conflitar com o XR
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.MovePosition(posInicial);
                rb.MoveRotation(rotInicial);
            }
            else
            {
                // Teleporte simples de segurança caso não ache a física
                objetoParaResetar.transform.position = posInicial;
                objetoParaResetar.transform.rotation = rotInicial;
            }
        }
    }
}
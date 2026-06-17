using UnityEngine;
using UnityEngine.UI; // Necessário para acessar o componente Image

public class TesteBotao : MonoBehaviour
{
    private Image imagemDoBotao;

    void Start()
    {
        // Pega o componente Image que está no mesmo objeto que este script
        imagemDoBotao = GetComponent<Image>();
    }

    // Método público para ser chamado pelo evento
    public void MudarCor()
    {
        if (imagemDoBotao != null)
        {
            // Muda para uma cor aleatória
            imagemDoBotao.color = new Color(Random.value, Random.value, Random.value);
            Debug.Log("Botão clicado com sucesso!");
        }
    }
}
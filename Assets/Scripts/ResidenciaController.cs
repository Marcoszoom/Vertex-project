using UnityEngine;

public class ResidenciaController : MonoBehaviour
{
    // Usamos [SerializeField] para editar a referência no Inspector
    [SerializeField] private Transform modeloResidencia;

    // Método para ser usado no Slider (Dynamic float)
    // O Unity passará automaticamente o valor do Slider para 'valor'
    public void SetScale(float valor)
    {
        if (modeloResidencia != null)
        {
            modeloResidencia.localScale = new Vector3(valor, valor, valor);
        }
    }

    // Método para ser usado no Slider de Rotação (Dynamic float)
    public void SetRotation(float valor)
    {
        if (modeloResidencia != null)
        {
            // O valor do slider (0 a 1) é multiplicado por 360 para girar 360 graus
            modeloResidencia.localRotation = Quaternion.Euler(0, valor * 360f, 0);
        }
    }

    // Exemplo de método para Botão (Sem parâmetros)
    [ContextMenu("Resetar Modelo")]
    public void ResetarPosicao()
    {
        if (modeloResidencia != null)
        {
            modeloResidencia.localScale = Vector3.one;
            modeloResidencia.localRotation = Quaternion.identity;
        }
    }
}
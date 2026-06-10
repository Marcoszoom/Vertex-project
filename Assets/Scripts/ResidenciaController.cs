using UnityEngine;

public class ResidenciaController : MonoBehaviour
{
    [Header("Model References")]
    [Tooltip("Referência ao Transform principal da maquete da residência.")]
    [SerializeField] private Transform modelTransform;

    [Tooltip("Referência ao GameObject alvo para alternar visibilidade.")]
    [SerializeField] private GameObject modelTargetObject;

    public void SetScale(float value)
    {
        // Assinatura para controle de escala via Slider
    }

    public void RotateModel(float value)
    {
        // Assinatura para controle de rotação via Slider/Botão
    }

    public void ToggleVisibility(bool status)
    {
        // Assinatura para ocultar/exibir via Toggle
    }
}
using UnityEngine;
using TMPro;

public class DatosJugador : MonoBehaviour
{
    public int puntuacion = 0;
    public TextMeshProUGUI textoPuntuacion;

    private void Update() {
        textoPuntuacion.text = "Puntuación: " + puntuacion.ToString();
    }
}
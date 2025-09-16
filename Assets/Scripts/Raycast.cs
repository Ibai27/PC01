using UnityEngine;

public class RaycastDesdeCamaraActiva : MonoBehaviour
{
    [Header("Distancia del rayo")]
    public float distanciaRayo = 100f;

    void Update()
    {
        // Lanza el rayo con clic izquierdo del ratón -  Si queremos que este siempre activo eliminar el if y dejar solo la referencia al metodo.
        if (Input.GetMouseButtonDown(0))
        {
            LanzarRayoDesdeCamaraActiva(); // Despues de entrar en el if utiliza el metodo de LanzarRayoDesdeCamaraActiva
        }
    }

    void LanzarRayoDesdeCamaraActiva()
    {
        Camera camaraActiva = ObtenerCamaraActiva();
        if (camaraActiva == null)
        {
            Debug.LogWarning("No hay ninguna cámara activa en la escena.");
            return;
        }

        // Crear el rayo desde el centro de la cámara activa
        Ray rayo = camaraActiva.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        // Dibujar el rayo en la Scene View (solo para depuración)
        Debug.DrawRay(rayo.origin, rayo.direction * distanciaRayo, Color.red, 2f);

        // Detectar colisiones con objetos
        if (Physics.Raycast(rayo, out RaycastHit impacto, distanciaRayo))
        {
            Debug.Log("Impacto con: " + impacto.collider.name + " desde la cámara: " + camaraActiva.name);
        }
    }

    // Busca la cámara habilitada en la escena
    Camera ObtenerCamaraActiva()
    {
        Camera[] camaras = Camera.allCameras;
        foreach (Camera camara in camaras)
        {
            if (camara.enabled)
            {
                return camara;
            }
        }
        return null;
    }
}


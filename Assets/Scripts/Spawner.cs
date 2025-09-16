using UnityEngine;

//Su función es leer los datos de un ScriptableObject y spawnear (instanciar) un prefab varias veces.
public class Spawner : MonoBehaviour
{

    public ScriptableObjectBolaUnity spawnData;   // Tenemos que cambiar este nombre de aquí

    //Start sirve para ejecutar automaticamente cuando empiece la escena
    void Start()
    {
        // Verifica que el ScriptableObject y el prefab no sean nulos.
        // El orden importa: primero se verifica que spawnData no sea null.
        if (spawnData == null || spawnData.prefabToSpawn == null)
        {
            Debug.LogError("Falta asignar el prefab o el ScriptableObject.");
            return;
        }

        for (int i = 0; i < spawnData.spawnCount; i++)
        {
            //Calcula la posicion de spanw de cada instancia usando la posicion inicial y un offset
            Vector3 spawnPos = spawnData.startPosition + i * spawnData.offset;

            //Instancia (clona) el prefab en la posicion calculada.
            Instantiate(spawnData.prefabToSpawn, spawnPos, Quaternion.identity);
        }
    }
}

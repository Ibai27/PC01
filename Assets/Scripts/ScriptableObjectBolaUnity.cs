using UnityEngine;

//Este atributo me permite crear una instancia de el scriptableObject
[CreateAssetMenu(fileName = "ScriptableObjectBolaUnity", menuName = "Scriptable Objects/ScriptableObjectBolaUnity")]
public class ScriptableObjectBolaUnity : ScriptableObject
{
    //El prefab que se va a instanciar , puede ser un objeto o una esfera ....
    public GameObject prefabToSpawn; 

    //Numero de veces que se va a clonar o instanciar el prefab. (Tambien se puede editar desde el inspector.)
    public int spawnCount = 1;

    //indica la posicion inicial desde donde se empezara a spawnear.
    public Vector3 startPosition = Vector3.zero;

    //Desplazamiento entre cada uno de los objetos clonados o instanciados - Vector 3 indica solo un vector con los 3 ejes(x,y,z).        
    public Vector3 offset = new Vector3(2, 0, 0); 
 
}

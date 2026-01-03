using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 3f; // Скорость движения
    
    void Update()
    {
        // Получаем нажатия клавиш
        float horizontal = Input.GetAxis("Horizontal"); // A/D или стрелки влево/вправо
        float vertical = Input.GetAxis("Vertical");     // W/S или стрелки вверх/вниз
        
        // Двигаем куб
        transform.Translate(horizontal * speed * Time.deltaTime, 
                          vertical * speed * Time.deltaTime, 
                          0);
    }
}
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // Скорость перемещения персонажа

    private Rigidbody rb;  // Ссылка на компонент Rigidbody

    private void Start()
    {
        rb = GetComponent<Rigidbody>();  // Получаем ссылку на компонент Rigidbody при запуске игры
    }

    private void FixedUpdate()
    {
        // Получаем ввод горизонтальной и вертикальной осей (направление движения)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Создаем вектор движения на основе ввода
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Добавляем вектор движения к позиции персонажа с учетом скорости и физики игры
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
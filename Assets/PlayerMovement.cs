using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // �������� ����������� ���������

    private Rigidbody rb;  // ������ �� ��������� Rigidbody

    private void Start()
    {
        rb = GetComponent<Rigidbody>();  // �������� ������ �� ��������� Rigidbody ��� ������� ����
    }

    private void FixedUpdate()
    {
        // �������� ���� �������������� � ������������ ���� (����������� ��������)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ������� ������ �������� �� ������ �����
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // ��������� ������ �������� � ������� ��������� � ������ �������� � ������ ����
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
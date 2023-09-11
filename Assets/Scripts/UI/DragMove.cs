using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// ��� ������Ʈ �̵� ��Ű��
public class DragMove : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public RectTransform moveObject; // �̵��� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 m_mousePosition;
    Vector3 mouseDelta; // ���콺�� ������Ʈ �߽� �� ����;
    Vector3 objectDelta; // ���� ������Ʈ�� ������ ��ü���� ����.

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnMouseDown");

        mouseDelta = Input.mousePosition - transform.position;
        objectDelta = moveObject.position - transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnMouseDrag");

        m_mousePosition = Input.mousePosition;
        moveObject.position = m_mousePosition - mouseDelta + objectDelta;
    }      

    //private void OnMouseDown()
    //{
    //    Debug.Log("OnMouseDown");

    //    delta = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    //}

    //private void OnMouseDrag()
    //{
    //    Debug.Log("OnMouseDrag");

    //    m_mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    moveObject.position = m_mousePosition - delta;
    //}
}

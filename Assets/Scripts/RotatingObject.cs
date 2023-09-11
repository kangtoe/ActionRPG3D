using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������Ʈ �ð�ȿ�� : ������ ȸ��, �� �Ʒ��� ��鸲
public class RotatingObject : MonoBehaviour
{

    //public float shakeAmount = 0.25f; // ��鸮�� ����
    //public float shakeSpeed = 1f;
    public float rotateSpeed = 180f;


    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(ShakeCr());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0), Space.World);
    }

    // ���Ʒ��� ����
    //IEnumerator ShakeCr() 
    //{
    //    float CurrentShake = 0;

    //    int multi = 1;
        
    //    while (true)
    //    {
    //        Debug.Log("CurrentShake: " + CurrentShake);

    //        float amount = shakeSpeed * Time.deltaTime * multi;
    //        CurrentShake += amount;
    //        transform.position += new Vector3(0, amount, 0);

    //        // �ִ�����
    //        if (CurrentShake >= shakeAmount)
    //        {
    //            Debug.Log("go down");
    //            multi = -1;
    //        }

    //        // �ּ�����
    //        else if (CurrentShake <= -shakeAmount)
    //        {
    //            Debug.Log("go up");
    //            multi = 1;
    //        }            

    //        yield return null;
    //    }       
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� ���͸��� ���� ȿ���� �ش�
public class DissolveEffect : MonoBehaviour
{
    public SkinnedMeshRenderer meshRenderer;            

    private void Start()
    {
        //meshRenderer = this.GetComponent<SkinnedMeshRenderer>();        
    }

    public void Dissolve(float duration)
    {
        StartCoroutine(DissolveCr(duration));
    }

    IEnumerator DissolveCr(float duration)
    {        
        float t = 0f;

        while (true)
        {
            if (t >= 1) break;
            t += Time.deltaTime / duration;

            Material[] mats = meshRenderer.materials;
            mats[0].SetFloat("_Cutoff", t);
            // Unity does not allow meshRenderer.materials[0]...
            meshRenderer.materials = mats;

            yield return null;
        }        
    }
}

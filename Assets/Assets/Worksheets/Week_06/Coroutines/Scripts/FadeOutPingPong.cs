using UnityEngine;
using System.Collections;

public class FadeOutPingPong : MonoBehaviour
{

    Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    private void OnMouseDown()
    {
        StartCoroutine(FadeOutpingpong());
    }

    IEnumerator FadeOutpingpong()
    {
        bool fadingOut = true;
        float alpha = 1f;

        while (true)
        {
            Color c = mat.color;
            c.a = alpha;
            mat.color = c;

            yield return new WaitForSeconds(0.05f);

            if (fadingOut)
            {
                alpha -= 0.05f;
                if (alpha <= 0f)
                {
                    alpha = 0f;
                    fadingOut = false;
                }
            }
            else
            {
                alpha += 0.05f;
                if (alpha >= 1f)
                {
                    alpha = 1f;
                    fadingOut = true;
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

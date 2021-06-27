using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderGenerator : MonoBehaviour
{

    [SerializeField] private GameObject Thunder;
    [SerializeField] private GameObject Warning;
    private Transform generator;
    private Light backLight;
    private Shader shaderGUItext;
    private Shader shaderDefault;
    public int rand = 0;
    public int blink = 6;
    // Start is called before the first frame update
    void Start()
    {
        generator = GameObject.Find("Thunder Generator").transform;
        backLight = GameObject.Find("Light").GetComponent<Light>();
        shaderGUItext = Shader.Find("GUI/Text Shader");
        shaderDefault = Shader.Find("Sprites/Default");
        blink = 6;

        InvokeRepeating("StartThunder", 2, 4);
        InvokeRepeating("StartThunder", 10.01f, 4);
        InvokeRepeating("StartThunder", 20.02f, 4);
        InvokeRepeating("StartThunder", 40.03f, 2);
        InvokeRepeating("StartThunder", 60.04f, 2);
        InvokeRepeating("StartThunder", 80.05f, 2);
    }

    void StartThunder()
    {
        StartCoroutine("GenerateThunder");
    }

    private IEnumerator GenerateThunder()
    {
        if (rand == 0)
        {
            rand = Random.Range(1, 10);
            switch (rand)
            {

                case 1:
                    rand = 0;
                    Instantiate(Warning, new Vector3(-8, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(-8, 6.5f), new Quaternion(), generator), 1);

                    break;

                case 2:
                    rand = 0;
                    Instantiate(Warning, new Vector3(-6, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(-6, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 3:
                    rand = 0;
                    Instantiate(Warning, new Vector3(-4, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(-4, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 4:
                    rand = 0;
                    Instantiate(Warning, new Vector3(-2, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(-2, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 5:
                    rand = 0;
                    Instantiate(Warning, new Vector3(0, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(0, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 6:
                    rand = 0;
                    Instantiate(Warning, new Vector3(2, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(2, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 7:
                    rand = 0;
                    Instantiate(Warning, new Vector3(4, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(4, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 8:
                    rand = 0;
                    Instantiate(Warning, new Vector3(6, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(6, 6.5f), new Quaternion(), generator), 1);
                    break;

                case 9:
                    rand = 0;
                    Instantiate(Warning, new Vector3(8, 4, -2), new Quaternion());
                    yield return new WaitForSeconds(2);
                    Destroy(Instantiate(Thunder, new Vector2(8, 6.5f), new Quaternion(), generator), 1);
                    break;

                default:
                    yield break;

            }
        }
        if (blink == 6) { InvokeRepeating("BlinkingAnim", .01f, .02f); }
        yield return new WaitForSeconds(2);
        yield break;
    }

    void BlinkingAnim()
    {
        if (blink < 0)
        {
            blink = 6;
            CancelInvoke("BlinkingAnim");
            backLight.intensity = .5f;
            return;
        }
        //Switch between two shaders to make blinking anim
        if (backLight.intensity == 0)
        {
            blink--;
            backLight.intensity = 10;
            return;
        }
        else
        {
            blink--;
            backLight.intensity = 0;
            return;
        }

    }
}

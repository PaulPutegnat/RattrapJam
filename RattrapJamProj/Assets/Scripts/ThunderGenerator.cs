using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderGenerator : MonoBehaviour
{

    [SerializeField] private GameObject Thunder;
    [SerializeField] private GameObject Warning;
    private Transform generator;
    public int rand = 0;
    private float delay = 2;
    // Start is called before the first frame update
    void Start()
    {
        generator = GameObject.Find("Thunder Generator").transform;
        InvokeRepeating("Timer", 2, delay);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void Timer()
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
                    Instantiate(Warning, new Vector2(-8, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(-8, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 2:
                    Instantiate(Warning, new Vector2(-6, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(-6, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 3:
                    Instantiate(Warning, new Vector2(-4, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(-4, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 4:
                    Instantiate(Warning, new Vector2(-2, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(-2, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 5:
                    Instantiate(Warning, new Vector2(0, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(0, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 6:
                    Instantiate(Warning, new Vector2(2, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(2, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 7:
                    Instantiate(Warning, new Vector2(4, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(4, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 8:
                    Instantiate(Warning, new Vector2(6, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(6, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                case 9:
                    Instantiate(Warning, new Vector2(8, 4), new Quaternion());
                    yield return new WaitForSeconds(delay);
                    Destroy(Instantiate(Thunder, new Vector2(8, 6.5f), new Quaternion(), generator), 1);
                    rand = 0;
                    break;

                default:
                    yield break;

            }
        }
        yield return null;
    }
}

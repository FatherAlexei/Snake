using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private List<GameObject> Parts;
    private int pause = 0;
    private GameObject buf = null;
    [SerializeField] private GameObject[] _parts;

    private void Start()
    {
        Parts = new List<GameObject>(_parts);
        StartCoroutine(Move(0, 0.3f));
    }

    private void Update()
    {
        //Have to fix
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new Vector2(transform.position.x - 0.35f, transform.position.y + 0.3f);
            StopAllCoroutines();
            StartCoroutine(Move(-0.3f, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector2(transform.position.x-0.35f, transform.position.y - 0.3f);
            StopAllCoroutines();
            StartCoroutine(Move(-0.3f, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector2(transform.position.x - 0.35f, transform.position.y - 0.3f);
            StopAllCoroutines();
            StartCoroutine(Move(-0.3f, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector2(transform.position.x - 0.35f, transform.position.y - 0.3f);
            StopAllCoroutines();
            StartCoroutine(Move(-0.3f, 0));
        }
    }

    IEnumerator Move(float x, float y)
    {
        for (int i = 10; i > 0; i++)
        {
            for(int j = Parts.Count-1; j > 0; j--)
            {
                Parts[j].transform.position = new Vector2(Parts[j-1].transform.position.x, Parts[j - 1].transform.position.y);
            }
            Parts[0].transform.position = new Vector2(transform.position.x, transform.position.y);
            gameObject.transform.position = new Vector2(transform.position.x + x, transform.position.y + y);
            if(MyTrigger.CreatePart == true)
            {
                pause++;
                buf = Instantiate(Parts[Parts.Count-1]);
                if(pause == 2)
                {
                    Parts.Add(buf);
                    pause = 0;
                    buf = null;
                    MyTrigger.CreatePart = false;
                }
            }
            yield return new WaitForSeconds(.5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)

            instance = this;

        else if (instance != this)

            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator FocusOn(CharSprite who, float length)
    {
        float time = 0;
        while (time < length)
        {
            time += Time.deltaTime;
            transform.position = who.transform.position + Vector3.back;
            yield return null;
        }
    }
}

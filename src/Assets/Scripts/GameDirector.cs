using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class GameDirector : MonoBehaviour
{
    [SerializeField] GameObject prefabMessage = default!;
    [SerializeField] GameObject gameObjectCanvas = default!;
    [SerializeField] PlayDirector playDirector = default!;
    GameObject _message = null;

    void CreateMessage(string message)
    {
        Debug.Assert(_message == null);
        _message = Instantiate(prefabMessage, Vector3.zero, Quaternion.identity,
            gameObjectCanvas.transform);
        _message.transform.localPosition = new Vector3(0, 0, 0);

        _message.GetComponent<TextMeshProUGUI>().text = message;
    }


    // Start is called before the first frame update

}

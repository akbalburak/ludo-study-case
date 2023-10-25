using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class RandomDiceService : Singleton<RandomDiceService>
{
    [SerializeField]
    private string _randomApiUrl;

    private Stack<int> _dices = new Stack<int>();

    private void Awake()
    {
        StartCoroutine(LoadDices());
    }

    private IEnumerator LoadDices()
    {
        UnityWebRequest request = UnityWebRequest.Get(_randomApiUrl);
        yield return request.SendWebRequest();

        // IF THERE IS AN ERROR IN RESPONSE WE JUST RETURN.
        if (request.responseCode != 200)
        {
            Debug.LogError(request.error);
            yield break;
        }

        // WE PARSE ALL THE INCOMING NUMBERS AND PUT THEM INTO DICES LIST.
        List<string> numberStrings = request.downloadHandler.text
            .Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        numberStrings.ForEach(y =>
        {
            if (int.TryParse(y, out int number))
                _dices.Push(number);
        });
    }

    public int GetDiceNumber()
    {
        // IF THERE IS A NUMBER IN THE LIST WE RETURN IT.
        if (_dices.TryPop(out int number))
        {
            if (_dices.Count == 0)
                StartCoroutine(LoadDices());

            return number;
        }

        // OTHERWISE WE JUST RETURN A RANDOM NUMBER.
        return UnityEngine.Random.Range(1, 7);
    }
}

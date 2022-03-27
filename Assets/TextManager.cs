using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countdown;

    public bool doneCounting = false;
    // Start is called before the first frame update

    public IEnumerator UpdateCountdown()
    {
        yield return new WaitForSeconds(1);
        var counter = 3;
        while(counter > 0)
        {
            _countdown.SetText(counter.ToString());
            counter--;
            yield return new WaitForSeconds(1);
        }
        _countdown.SetText("SAUSAGE TIME!");
        yield return new WaitForSeconds(1);
        _countdown.SetText("");
        doneCounting = true;
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{
    [SerializeField] private bool showFullValue = true; 

    private void Start()
    {
        StoredValue<int> hint = GameState.hint;
        hint.onValueChanged = (Action)Delegate.Combine(hint.onValueChanged, new Action(OnValueChanged));
        OnValueChanged();
    }

    private void OnValueChanged()
    {
        int hintValue = GameState.hint.GetValue();

        if (showFullValue)
        {
            // Show the full value
            GetComponent<Text>().text = hintValue.ToString();
        }
        else
        {
            // Show "99+" if the value exceeds 100
            if (hintValue > 100)
            {
                GetComponent<Text>().text = "99+";
            }
            else
            {
                GetComponent<Text>().text = hintValue.ToString();
            }
        }
    }

    private void OnDestroy()
    {
        StoredValue<int> hint = GameState.hint;
        hint.onValueChanged = (Action)Delegate.Remove(hint.onValueChanged, new Action(OnValueChanged));
    }
}
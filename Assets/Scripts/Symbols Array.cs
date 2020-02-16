using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolsArray : MonoBehaviour
{
    public Symbol[] Symbols { get; private set; }


    public Symbol GetSymbolAt(int i)
    {
        return Symbols[i];
    }

    public void WriteSymbolAt(int i, Symbol s)
    {
        Symbols[i] = s;
    }
}
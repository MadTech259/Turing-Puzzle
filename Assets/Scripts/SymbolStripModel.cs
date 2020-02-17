using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolStripModel : MonoBehaviour, ISymbolsStripModel
{
    private Symbol[] _symbols;

    public Symbol[] Symbols
    {
        get => _symbols;
        set => _symbols = value;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolsStripController : MonoBehaviour, ISymbolsStripController
{
    [SerializeField] private SymbolStripModel _model;


    public Symbol GetSymbolAt(int i)
    {
        return _model.Symbols[i];
    }

    public void WriteSymbolAt(int i, Symbol s)
    {
        _model.Symbols[i] = s;
    }
}
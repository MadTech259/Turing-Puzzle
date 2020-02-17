using System.Collections;
using UnityEngine;

public class ReadingHeadController : MonoBehaviour
{
    
    [SerializeField] private IReadingHeadModel _model;

    [SerializeField] private ISymbolsStripController _symbolsStripController;

    public void MoveLeft(int i)
    {
        _model.Position += i;
    }
    
    public void MoveRight(int i)
    {
        _model.Position -= i;
    }

    public void ReadStrip(StateTableController t)
    {
        Symbol currentSymbol = _symbolsStripController.GetSymbolAt(_model.Position);
        t.Execute(currentSymbol);

    }
}
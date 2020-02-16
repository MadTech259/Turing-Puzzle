using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingHeadBehaviour : MonoBehaviour
{
    public int Position { get; private set; }

    public void MoveLeft(int i)
    {
        Position += i;
    }

    public void ReadStrip(SymbolsArray s, StateTable t)
    {
        Symbol currentSymbol = s.GetSymbolAt(Position);
        t.Execute(currentSymbol);

    }
}

public class StateTable : MonoBehaviour
{
    private Dictionary<Symbol, MachineInstruction> instructions;
    
    public void Execute(Symbol currentSymbol)
    {
        MachineInstruction instruction;
        if (instructions.TryGetValue(currentSymbol, out instruction))
        {
            instruction.Run(this);
        }
    }
}

public class MachineInstruction
{
    public void Run(StateTable stateTable)
    {
        
    }
}

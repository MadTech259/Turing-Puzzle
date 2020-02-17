using System.Collections.Generic;

public class StateTableModel : IStateTableModel
{
    private Dictionary<Symbol, IMachineInstructionModel> _instructions;
    
    public Dictionary<Symbol, IMachineInstructionModel> Instructions
    {
        get => _instructions;
        set => _instructions = value;
    }
}
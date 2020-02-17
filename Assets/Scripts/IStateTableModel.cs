using System.Collections.Generic;

public interface IStateTableModel
{
    Dictionary<Symbol, IMachineInstructionModel> Instructions { get; set; }
}
using UnityEngine;

public class StateTableController : MonoBehaviour, IStateTableController
{
    
    [SerializeField] private IStateTableModel _model;
    [SerializeField] private IMachineInstructionController _instructionController;
    
    public void Execute(Symbol currentSymbol)
    {
        IMachineInstructionModel instructionModel;
        if (_model.Instructions.TryGetValue(currentSymbol, out instructionModel))
        {
            _instructionController.Run(instructionModel);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorController
{
    // 1. INTERFACE - Make this public
    public interface IElevatorState
    {
        string StateName { get; }
        void HandleMove(ElevatorGui controller);
        void HandleStop(ElevatorGui controller);
        void HandleDoorOperation(ElevatorGui controller);
    }

    // 2. STATE CLASSES - Make them public
    public class MovingUpState : IElevatorState
    {
        public string StateName => "Moving Up";

        public void HandleMove(ElevatorGui controller)
        {
            Console.WriteLine("Already moving up");
        }

        public void HandleStop(ElevatorGui controller)
        {
            Console.WriteLine("Stopping from moving up state");
        }

        public void HandleDoorOperation(ElevatorGui controller)
        {
            Console.WriteLine("Cannot open doors while moving");
        }
    }

    public class MovingDownState : IElevatorState
    {
        public string StateName => "Moving Down";

        public void HandleMove(ElevatorGui controller)
        {
            Console.WriteLine("Already moving down");
        }

        public void HandleStop(ElevatorGui controller)
        {
            Console.WriteLine("Stopping from moving down state");
        }

        public void HandleDoorOperation(ElevatorGui controller)
        {
            Console.WriteLine("Cannot open doors while moving");
        }
    }

    public class StoppedState : IElevatorState
    {
        public string StateName => "Stopped";

        public void HandleMove(ElevatorGui controller)
        {
            Console.WriteLine("Starting movement from stopped state");
        }

        public void HandleStop(ElevatorGui controller)
        {
            Console.WriteLine("Already stopped");
        }

        public void HandleDoorOperation(ElevatorGui controller)
        {
            Console.WriteLine("Can open/close doors while stopped");
        }
    }

    // 3. CONTEXT CLASS - Make this public and remove "internal"
    public class ElevatorStateContext
    {
        private IElevatorState _currentState;

        public ElevatorStateContext()
        {
            _currentState = new StoppedState();
        }

        public void SetState(IElevatorState state)
        {
            _currentState = state;
            Console.WriteLine($"State changed to: {_currentState.StateName}");
        }

        public void HandleMove(ElevatorGui controller) => _currentState.HandleMove(controller);
        public void HandleStop(ElevatorGui controller) => _currentState.HandleStop(controller);
        public void HandleDoorOperation(ElevatorGui controller) => _currentState.HandleDoorOperation(controller);
    }
}

using UnityEngine;

namespace BaseCode.Command
{
    public class MoveCommand : ICommand
    {
        private readonly CubeMover _cubeMover;
        private readonly Vector3 _movement;

        public MoveCommand(CubeMover cubeMover, Vector3 movement)
        {
            _cubeMover = cubeMover;
            _movement = movement;
        }
        
        public void Execute() => _cubeMover.Move(_movement);

        public void Undo() => _cubeMover.Move(-_movement);
    }
}
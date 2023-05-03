using System.Collections.Generic;

namespace BaseCode.Command
{
    public class CommandInvoker
    {
        private static Stack<ICommand> undoStack = new ();
        private static Stack<ICommand> redoStack = new ();

        public static void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
        }

        public static void UndoCommand()
        {
            if (undoStack.Count > 0)
            {
                var activeCommand = undoStack.Pop();
                redoStack.Push(activeCommand);
                activeCommand.Undo();
            }
        }
        
        public static void RedoCommand()
        {
            if (redoStack.Count > 0)
            {
                var activeCommand = redoStack.Pop();
                undoStack.Push(activeCommand);
                activeCommand.Execute();
            }
        }
    }
}
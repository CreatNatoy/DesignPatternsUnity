namespace BaseCode.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
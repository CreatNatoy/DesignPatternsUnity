namespace BaseCode.Singleton
{
    public class Message2 : Singleton<Message2>
    {
        public string MessageText => "It's nice day"; 
    }
}
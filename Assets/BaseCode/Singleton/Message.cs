namespace BaseCode.Singleton
{
    public class Message : Singleton<Message>
    {
        public string MessageText => "Hello world!";
    }
}
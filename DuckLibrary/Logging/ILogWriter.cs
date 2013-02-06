namespace DuckLibrary.Logging
{
    public interface ILogWriter
    {
        void WriteMessage(string message);
    }
}
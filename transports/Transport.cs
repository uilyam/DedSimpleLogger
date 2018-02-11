namespace DedSimpleLogger.Transports
{
    /// <summary>
    /// Transport interface that all logging transports must implement.
    /// </summary>
    interface Transport<T>
    {
        void Log(string message);
    }
}

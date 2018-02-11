using UnityEngine;

namespace DedSimpleLogger.Transports
{
    /// <summary>
    /// Logging transport for the Unity Console.
    /// </summary>
    class UnityConsole : Transport<UnityConsole>
    {
        /// <summary>
        /// Log formatted messages to the Unity console.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public void Log(string message) {
            Debug.Log(message);
        }
    }
}

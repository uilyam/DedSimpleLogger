using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DedSimpleLogger.Transports;

namespace DedSimpleLogger
{
    /// <summary>
    /// No dependency hierachical logger to include in your next game.
    /// </summary>
    class DLogger : MonoBehaviour {

        /// <summary>
        /// The system name is prepended to all logs.
        /// </summary>
        private static string logPrefix = "DedSimpleLogger";
        
        /// <summary>
        /// Determines whether a log call should be delegated to the system.
        /// </summary>
        private static LogLevels logLevel = LogLevels.Info;

        private static Transport<UnityConsole> transport = new UnityConsole();

        /// <summary>
        /// Configure the logger for your application.  Call this method
        /// during your setup/configuration phase.
        /// </summary>
        /// <param name="prefix">Prefix to use for your logs.</param>
        /// <param name="logLevel">Log level to evaluate your log calls against.</param>
        public static void Configure(string logPrefix, LogLevels logLevel = LogLevels.Info) {
            DLogger.logPrefix = logPrefix;
            DLogger.logLevel = logLevel;
        }

        /// <summary>
        /// Log a message to the Unity console with a given log level. If no log level
        /// is provided, the default is Info (LogLevel.Info). 
        /// </summary>
        /// <param name="message">Message to log.</param>
        /// <param name="messageLevel">Log level to use for the message.</param>
        public static void Log(string message, LogLevels messageLevel = LogLevels.Info) {
            if (DLogger.CanBeLogged(messageLevel)) {
                DLogger.transport.Log(DLogger.FormatMessage(message));
            }
        }

        /// <summary>
        /// Determine if a given message's log level should be logged based on it's hierarchy status.
        /// </summary>
        /// <param name="messageLevel">The level of the message to check.</param>
        /// <returns>True if the message should be logged, and False otherwise.</returns>
        public static bool CanBeLogged(LogLevels messageLevel) {
            return DLogger.logLevel <= messageLevel;
        }

        /// <summary>
        /// Format a message to be printed to the console. to prevent unecessary processing, this method should only be called
        /// if the message will be indeed be logged.
        /// </summary>
        /// <param name="message">Message to format"</param>
        /// <returns>A formatted message.</returns>
        public static string FormatMessage(string message) {
            return string.Format("{0}:{1} - {2}", DLogger.logPrefix, DateTime.Now, message);
        }

        /// <summary>
        /// Log a message with the All (LogLevel.All) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void All(string message) {
            DLogger.Log(message, LogLevels.All);
        }
    
        /// <summary>
        /// Log a message with the Trace (LogLevel.Trace) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Trace(string message) {
            DLogger.Log(message, LogLevels.Trace);
        }

        /// <summary>
        /// Log a message with the Debug (LogLevel.Debug) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Debug(string message) {
            DLogger.Log(message, LogLevels.Debug);
        }

        /// <summary>
        /// Log a message with the Info (LogLevel.Info) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Info(string message) {
            DLogger.Log(message, LogLevels.Info);
        }

        /// <summary>
        /// Log a message with the Warn (LogLevel.Warn) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Warn(string message) {
            DLogger.Log(message, LogLevels.Warn);
        }

        /// <summary>
        /// Log a message with the Error (LogLevel.Error) log level. Delegates to LoDLoggergger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Error(string message) {
            DLogger.Log(message, LogLevels.Error);
        }

        /// <summary>
        /// Log a message with the Fatal (LogLevel.Fatal) log level. Delegates to DLogger.Log.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Fatal(string message) {
            DLogger.Log(message, LogLevels.Fatal);
        }

        /// <summary>
        /// LogLevel options that allow you to configure what messages should be written to the console.
        /// Log levels are hierarchical in that every log call is evaluated against the log level hierarchy.
        /// If the level is equal to or greater than, the message is displayed. Read this order in decending order.
        /// Everything below (higher count) is logged for a given level.
        /// 1. All - Everything is logged.
        /// 2. Trace
        /// 3. Debug
        /// 4. Info
        /// 5. Warn
        /// 6. Error
        /// 7. Fatal
        /// 9. NoLog - Nothing is loggged.
        /// </summary>
        public enum LogLevels {All=1, Trace=2, Debug=3, Info=4, Warn=5, Error=6, Fatal=7, NoLog=9};
    }
}

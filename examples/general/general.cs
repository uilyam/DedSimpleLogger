using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;

public class main : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		// Configure the Logger with your desired prefix and log level.
		DLogger.Configure("My Game", DLogger.LogLevels.Debug);
		// Log at the Debug Log Level (Equal).
		DLogger.Debug("This debug message will be recorded.");
		// Log at the Trace Log Level (Lower).
		DLogger.Trace("This trace message will not be recorded.");
		// Log at the Info Log Level (Higher).
		DLogger.Info("This info message will be recored.");
		// Log at the Info Log Level (Higher).
		DLogger.Log("This general log (info) message will be recorded.");
	}
	
	// Update is called once per frame
	void Update () {
		// Log every frame update at the Debug level.
		DLogger.Debug("Frame update.");
	}
}

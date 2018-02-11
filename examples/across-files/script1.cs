using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;

public class script1 : MonoBehaviour {

	void Awake() {		
		// Configure the Logger with your desired prefix and log level.
		DLogger.Configure("My Game", DLogger.LogLevels.Info);
		// Log at the Debug Log Level (Less).
		DLogger.Debug("script1 - This debug message will not recorded.");
		// Log at the Info Log Level (Equal).
		DLogger.Info("script1 - I configured my logger in script1");
	}

	void Start () {
		DLogger.Log("script1 - started.");
	}
}

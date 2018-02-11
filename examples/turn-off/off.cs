using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;
public class off : MonoBehaviour {
	private bool isProduction = true;
	void Awake() {
		// Configure the logger as normal.
		DLogger.Configure("My Game", DLogger.LogLevels.Info);
		DLogger.Log("Logs.");
		// Some check to see if we should not be logging.
		if (this.isProduction) {
			DLogger.TurnOff();
		}
		DLogger.Log("Does not log.");
	}
	void Start () {
		// No level will log.
		DLogger.All("I will not show up in the console because logging is off.");
		DLogger.Trace("I will not show up in the console because logging is off.");
		DLogger.Debug("I will not show up in the console because logging is off.");
		DLogger.Info("I will not show up in the console because logging is off.");
		DLogger.Warn("I will not show up in the console because logging is off.");
		DLogger.Error("I will not show up in the console because logging is off.");
		DLogger.Fatal("I will not show up in the console because logging is off.");
	}
}

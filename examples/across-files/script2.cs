using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;

public class script2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Log at the Info level (Equal).
		DLogger.Log("script2 - Started.  Note the prefix should be what you configured.");
		// Log at the Debug Level (Less).
		DLogger.Debug("script2 - In script1 we set log level to Info, this should not display");
	}
}

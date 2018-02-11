using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;
public class minimal : MonoBehaviour {

	void Awake () {
		// You can opt to use the default prefix and log level (info).
		DLogger.Log("using defaults, this will show.");
		DLogger.Debug("using defaults, this will not show.");
	}
}

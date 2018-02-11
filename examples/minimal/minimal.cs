using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Include the logger
using DedSimpleLogger;
public class minimal : MonoBehaviour {

	void Awake () {
		// Default prefix is the package name, and log level is info.
		DLogger.Log("Configured Logger");
	}
}

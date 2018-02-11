# DedSimpleLogger

## Purpose

To provide a simple plugin that enables hierarchical logging throughout a Unity application.

## Getting Started

* Import the package.  You can download the latest for the release section.
* Include the namespace in your project.

```c#
using DedSimpleLogger;
```

* Start logging

```c#
using UnityEngine;
using DedSimpleLogger;

class ExampleClass : MonoBehavoiur {
    void Start() {
        DLogger.Log("I can log to the console.");
    }
}
```

* Optional: Configure the Logger (Do once)

```c#
using UnityEngine;
using DedSimpleLogger;

class ExampleClass : MonoBehavoiur {
    void Awake() {
        DLogger.Configure("My Game", DLogger.LogLevels.Debug);
    }
    void Start() {
        DLogger.Trace("I won't log to the console.");
        DLogger.Log("I will log to the console.");
        DLogger.Info("I will log to the console.");
    }
}
```

## Released Functionality

* Ability to configure the log prefix and level, or use defaults.
* Application wide hierarchical logging through static methods.
* Easily turn off logging throughout the application when moving to production.

## Proposed Functionality

* Expanded support for transports.
* Popular cloud logging transports provided.

## License

MIT, do as you wish.
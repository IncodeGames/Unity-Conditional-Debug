# Unity-Conditional-Debug
Library that wraps the methods of Unity's Debug class, marking them as Conditional to allow easy stripping from release builds while keeping stack traces.

Grab the Debug.DLL from the bin/Debug folder to get access to basic UnityEngine.Debug wrappings, or add further wrappings/functionality to the Debug.cs class and rebuild the project.

To Use:

Add the Debug.DLL file to the Unity project under Assets/Plugins.
In the Unity Project Settings under Player, add DEBUG_LOGGING to the area titled "Scripting Define Symbols." Make sure to separate it with a semicolon if there are other define symbols.

If you want to remove all logging from a build (or any other time), simply remove DEBUG_LOGGING from the Scripting Define Symbols area.

That's it!

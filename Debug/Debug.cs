using System.Diagnostics;
using UnityEngine;

namespace Incode
{
    public static class Debug
    {
        //This exact string must be included in Unity's Scripting Define Symbols
        public const string DEBUG_LOGGING = "DEBUG_LOGGING";

        [Conditional(DEBUG_LOGGING)]
        public static void Assert(bool condition)
        {
            UnityEngine.Debug.Assert(condition);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void Log(object str)
        {
            UnityEngine.Debug.Log(str);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogFormat(string str, params object[] args)
        {
            UnityEngine.Debug.LogFormat(str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogFormat(Object context, string str, params object[] args)
        {
            UnityEngine.Debug.LogFormat(context, str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogWarning(object str)
        {
            UnityEngine.Debug.LogWarning(str);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogWarningFormat(string str, params object[] args)
        {
            UnityEngine.Debug.LogWarningFormat(str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogWarningFormat(Object context, string str, params object[] args)
        {
            UnityEngine.Debug.LogWarningFormat(context, str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogError(object str)
        {
            UnityEngine.Debug.LogError(str);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogErrorFormat(string str, params object[] args)
        {
            UnityEngine.Debug.LogErrorFormat(str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void LogErrorFormat(Object context, string str, params object[] args)
        {
            UnityEngine.Debug.LogErrorFormat(context, str, args);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawLine(Vector3 start, Vector3 end)
        {
            UnityEngine.Debug.DrawLine(start, end);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawLine(Vector3 start, Vector3 end, Color color)
        {
            UnityEngine.Debug.DrawLine(start, end, color);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
        {
            UnityEngine.Debug.DrawLine(start, end, color, duration);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
        {
            UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawRay(Vector3 start, Vector3 dir)
        {
            UnityEngine.Debug.DrawRay(start, dir);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color)
        {
            UnityEngine.Debug.DrawRay(start, dir, color);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
        {
            UnityEngine.Debug.DrawRay(start, dir, color, duration);
        }

        [Conditional(DEBUG_LOGGING)]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
        {
            UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
        }
    }
}

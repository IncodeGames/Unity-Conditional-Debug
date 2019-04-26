using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace IncodeDebug
{
    public static class Debug
    {
        [Conditional("DEBUG_LOGGING")]
        public static void Log(object str)
        {
            UnityEngine.Debug.Log(str);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void LogFormat(string str, object[] args)
        {
            UnityEngine.Debug.LogFormat(str, args);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void LogWarning(object str)
        {
            UnityEngine.Debug.LogWarning(str);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void LogWarningFormat(string str, object[] args)
        {
            UnityEngine.Debug.LogWarningFormat(str, args);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void LogError(object str)
        {
            UnityEngine.Debug.LogError(str);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void LogErrorFormat(string str, object[] args)
        {
            UnityEngine.Debug.LogErrorFormat(str, args);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void DrawRay(Vector3 start, Vector3 dir)
        {
            UnityEngine.Debug.DrawRay(start, dir);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color)
        {
            UnityEngine.Debug.DrawRay(start, dir, color);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
        {
            UnityEngine.Debug.DrawRay(start, dir, color, duration);
        }

        [Conditional("DEBUG_LOGGING")]
        public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
        {
            UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
        }
    }
}

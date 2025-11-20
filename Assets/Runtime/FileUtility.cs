/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  FileUtility.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  11/20/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace MGS.IOUtility
{
    public sealed class FileUtility
    {
        #region
        public static string ReadAllText(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return null;
            }
        }

        public static IEnumerable<string> ReadLines(string path)
        {
            try
            {
                return File.ReadLines(path);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return null;
            }
        }

        public static byte[] ReadAllBytes(string path)
        {
            try
            {
                return File.ReadAllBytes(path);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return null;
            }
        }
        #endregion

        #region
        public static bool WriteAllText(string path, string contents)
        {
            if (!RequireDirectory(path))
            {
                return false;
            }

            try
            {
                File.WriteAllText(path, contents);
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }

        public static bool WriteAllLines(string path, IEnumerable<string> contents)
        {
            if (!RequireDirectory(path))
            {
                return false;
            }

            try
            {
                File.WriteAllLines(path, contents);
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }

        public static bool WriteAllBytes(string path, byte[] bytes)
        {
            if (!RequireDirectory(path))
            {
                return false;
            }

            try
            {
                File.WriteAllBytes(path, bytes);
                return true;
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }

        public static bool RequireDirectory(string path)
        {
            var dir = Path.GetDirectoryName(path);
            return DirectoryUtility.Require(dir);
        }
        #endregion
    }
}
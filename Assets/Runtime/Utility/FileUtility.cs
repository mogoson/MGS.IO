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

namespace MGS.IO
{
    public sealed class FileUtility
    {
        #region
        public static FileStream Create(string path, out Exception error)
        {
            error = null;
            try
            {
                return File.Create(path);
            }
            catch (Exception ex)
            {
                error = ex;
                return null;
            }
        }

        public static Exception Delete(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            try
            {
                File.Delete(path);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
        #endregion

        #region
        public static string ReadAllText(string path, out Exception error)
        {
            error = null;
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                error = ex;
                return null;
            }
        }

        public static IEnumerable<string> ReadLines(string path, out Exception error)
        {
            error = null;
            try
            {
                return File.ReadLines(path);
            }
            catch (Exception ex)
            {
                error = ex;
                return null;
            }
        }

        public static byte[] ReadAllBytes(string path, out Exception error)
        {
            error = null;
            try
            {
                return File.ReadAllBytes(path);
            }
            catch (Exception ex)
            {
                error = ex;
                return null;
            }
        }
        #endregion

        #region
        public static Exception WriteAllText(string path, string contents)
        {
            var error = RequireDirectory(path);
            if (error != null)
            {
                return error;
            }

            try
            {
                File.WriteAllText(path, contents);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception WriteAllLines(string path, IEnumerable<string> contents)
        {
            var error = RequireDirectory(path);
            if (error != null)
            {
                return error;
            }

            try
            {
                File.WriteAllLines(path, contents);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception WriteAllBytes(string path, byte[] bytes)
        {
            var error = RequireDirectory(path);
            if (error != null)
            {
                return error;
            }

            try
            {
                File.WriteAllBytes(path, bytes);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception RequireDirectory(string path)
        {
            var dir = Path.GetDirectoryName(path);
            return DirectoryUtility.Require(dir);
        }
        #endregion
    }
}
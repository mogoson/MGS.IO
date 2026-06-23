/*************************************************************************
 *  Copyright © 2025 Mogoson All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  DirectoryUtility.cs
 *  Description  :  Default.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  11/20/2025
 *  Description  :  Initial development version.
 *************************************************************************/

using System;
using System.IO;

namespace MGS.IOUtility
{
    public sealed class DirectoryUtility
    {
        public static Exception Require(string path)
        {
            if (Directory.Exists(path))
            {
                return null;
            }

            try
            {
                Directory.CreateDirectory(path);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Exception Delete(string path)
        {
            if (!Directory.Exists(path))
            {
                return null;
            }

            try
            {
                Directory.Delete(path);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
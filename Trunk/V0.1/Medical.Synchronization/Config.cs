﻿using System;
using System.IO;

namespace Medical.Synchronization
{
    public class Config
    {
        public class StatupPath
        {
            private static bool bReadCurrent = false;
            private static string sCurrentPath = string.Empty;
            public static string CurrentPath
            {
                get
                {
                    if (bReadCurrent) return sCurrentPath;
                    sCurrentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";
                    bReadCurrent = true;
                    return sCurrentPath;
                }
            }

            private static bool bReadtmp = false;
            private static string sTempPath = string.Empty;
            public static string TempPath
            {
                get
                {
                    if (bReadtmp) return sTempPath;
                    sTempPath = System.Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine); ;
                    bReadtmp = true;
                    return sTempPath;
                }
            }
        }

        public class Constant
        {
            public const string INI_FILE_NAME = "Medical.syn";
            public const string INI_SECTION = "Medical.Synchronization.ConnectionInfo";
            public const string INI_SQL_SERVER = "SqlServer";
            public const string INI_SQL_DB_NAME = "SqlDbname";
            public const string INI_SQL_USER = "SqlUser";
            public const string INI_SQL_PASS = "SqlPass";
        }

        #region Connection string
        private static bool bReadConn = false;
        private static string sConnectionString = string.Empty, UserName = string.Empty, Password = string.Empty, ServerName = string.Empty, DBName = string.Empty;
        public static string ConnectionString
        {
            get
            {
                if (bReadConn) return sConnectionString;
                string TempPath = StatupPath.CurrentPath;
                string IniPath = TempPath + Constant.INI_FILE_NAME;
                if (System.IO.File.Exists(IniPath))
                {
                    IniFile iniFile = new IniFile(IniPath);
                    UserName = iniFile.IniReadValue(Constant.INI_SECTION, Constant.INI_SQL_USER);
                    UserName = TripleDes.Decode(Constant.INI_SQL_USER, UserName);
                    Password = iniFile.IniReadValue(Constant.INI_SECTION, Constant.INI_SQL_PASS);
                    Password = TripleDes.Decode(Constant.INI_SQL_PASS, Password);
                    ServerName = iniFile.IniReadValue(Constant.INI_SECTION, Constant.INI_SQL_SERVER);
                    ServerName = TripleDes.Decode(Constant.INI_SQL_SERVER, ServerName);
                    DBName = iniFile.IniReadValue(Constant.INI_SECTION, Constant.INI_SQL_DB_NAME);
                    DBName = TripleDes.Decode(Constant.INI_SQL_DB_NAME, DBName);
                    sConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DBName + ";User ID=" + UserName + ";Password=" + Password + ";";
                    bReadConn = true;
                }
                return sConnectionString;
            }
        }
        #endregion
    }
}
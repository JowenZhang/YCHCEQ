using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andafa.Mes.Common.Tools
{
    /// <summary>
    /// convert tool
    /// </summary>
    public static class ConvertTool
    {
        /// <summary>
        /// object convert to string
        /// </summary>
        /// <param name="obj">object</param>
        /// <param name="timeFormat">datetime format string</param>
        /// <returns>string</returns>
        public static string GetString(object obj, string timeFormat = null)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return null;
            }
            DateTime? tmpDatetime = obj as DateTime?;
            if (string.IsNullOrWhiteSpace(timeFormat))
            {
                timeFormat = "yyyy-MM-dd HH:mm:ss.fff";
            }
            if (tmpDatetime.HasValue)
            {
                if (string.IsNullOrWhiteSpace(timeFormat.Trim()))
                {
                    return tmpDatetime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
                else
                {
                    try
                    {
                        return tmpDatetime.Value.ToString(timeFormat);
                    }
                    catch (Exception ex)
                    {
                        LogTool.Error(ex);
                        return tmpDatetime.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    }
                }
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// object convert to bool
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool, when could not convert then default</returns>
        public static bool GetBool(object obj)
        {
            bool boolTmp = false;
            return bool.TryParse(GetString(obj), out boolTmp) ? boolTmp : default(bool);
        }

        /// <summary>
        /// object convert to nullable bool
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable bool, when could not convert then null</returns>
        public static bool? GetBoolNull(object obj)
        {
            bool boolTmp = false;
            return bool.TryParse(GetString(obj), out boolTmp) ? (bool?)boolTmp : null;
        }

        /// <summary>
        /// object convert to byte
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>byte, when could not convert then default</returns>
        public static byte GetByte(object obj)
        {
            byte byteTmp = byte.MinValue;
            return byte.TryParse(GetString(obj), out byteTmp) ? byteTmp : default(byte);
        }

        /// <summary>
        /// object convert to nullable byte
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable byte, when could not convert then null</returns>
        public static byte? GetByteNull(object obj)
        {
            byte byteTmp = byte.MinValue;
            return byte.TryParse(GetString(obj), out byteTmp) ? (byte?)byteTmp : null;
        }

        /// <summary>
        /// object convert to char
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>char, when could not convert then default</returns>
        public static char GetChar(object obj)
        {
            char charTmp = char.MinValue;
            return char.TryParse(GetString(obj), out charTmp) ? charTmp : default(char);
        }

        /// <summary>
        /// object convert to nullable char
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable char, when could not convert then null</returns>
        public static char? GetCharNull(object obj)
        {
            char charTmp = char.MinValue;
            return char.TryParse(GetString(obj), out charTmp) ? (char?)charTmp : null;
        }

        /// <summary>
        /// object convert to decimal
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>decimal, when could not convert then default</returns>
        public static decimal GetDecimal(object obj)
        {
            Decimal decimalTmp = 0M;
            return decimal.TryParse(GetString(obj), out decimalTmp) ? decimalTmp : default(decimal);
        }

        /// <summary>
        /// object convert to nullable decimal
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable decimal, when could not convert then null</returns>
        public static decimal? GetDecimalNull(object obj)
        {
            Decimal decimalTmp = 0M;
            return decimal.TryParse(GetString(obj), out decimalTmp) ? (decimal?)decimalTmp : null;
        }

        /// <summary>
        /// object convert to double
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>double, when could not convert then default</returns>
        public static double GetDouble(object obj)
        {
            double doubleTmp = 0.0;
            return double.TryParse(GetString(obj), out doubleTmp) ? doubleTmp : default(double);
        }

        /// <summary>
        /// object convert to nullable double
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable double, when could not convert then null</returns>
        public static double? GetDoubleNull(object obj)
        {
            double doubleTmp = 0.0;
            return double.TryParse(GetString(obj), out doubleTmp) ? (double?)doubleTmp : null;
        }

        /// <summary>
        /// object convert to float
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>float, when could not convert then default</returns>
        public static float GetFloat(object obj)
        {
            float floatTmp = 0F;
            return float.TryParse(GetString(obj), out floatTmp) ? floatTmp : default(float);
        }

        /// <summary>
        /// object convert to nullable float
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable float, when could not convert then null</returns>
        public static float? GetFloatNull(object obj)
        {
            float floatTmp = 0F;
            return float.TryParse(GetString(obj), out floatTmp) ? (float?)floatTmp : null;
        }

        /// <summary>
        /// object convert to int
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>int, when could not convert then default</returns>
        public static int GetInt(object obj)
        {
            int intTmp = 0;
            return int.TryParse(GetString(obj), out intTmp) ? intTmp : default(int);
        }

        /// <summary>
        /// object convert to nullable int
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable int, when could not convert then null</returns>
        public static int? GetIntNull(object obj)
        {
            int intTmp = 0;
            return int.TryParse(GetString(obj), out intTmp) ? (int?)intTmp : null;
        }

        /// <summary>
        /// object convert to long
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>long, when could not convert then default</returns>
        public static long GetLong(object obj)
        {
            long longTmp = 0L;
            return long.TryParse(GetString(obj), out longTmp) ? longTmp : default(long);
        }

        /// <summary>
        /// object convert to nullable long
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable long, when could not convert then null</returns>
        public static long? GetLongNull(object obj)
        {
            long longTmp = 0L;
            return long.TryParse(GetString(obj), out longTmp) ? (long?)longTmp : null;
        }

        /// <summary>
        /// object convert to sbyte
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>sbyte, when could not convert then default</returns>
        public static sbyte GetSByte(object obj)
        {
            sbyte sbyteTmp = 0;
            return sbyte.TryParse(GetString(obj), out sbyteTmp) ? sbyteTmp : default(sbyte);
        }

        /// <summary>
        /// object convert to nullable sbyte
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable sbyte, when could not convert then null</returns>
        public static sbyte? GetSByteNull(object obj)
        {
            sbyte sbyteTmp = 0;
            return sbyte.TryParse(GetString(obj), out sbyteTmp) ? (sbyte?)sbyteTmp : null;
        }

        /// <summary>
        /// object convert to short
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>short, when could not convert then default</returns>
        public static short GetShort(object obj)
        {
            short shortTmp = 0;
            return short.TryParse(GetString(obj), out shortTmp) ? shortTmp : default(short);
        }

        /// <summary>
        /// object convert to nullable short
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable short, when could not convert then null</returns>
        public static short? GetShortNull(object obj)
        {
            short shortTmp = 0;
            return short.TryParse(GetString(obj), out shortTmp) ? (short?)shortTmp : null;
        }

        /// <summary>
        /// object convert to uint
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>uint, when could not convert then default</returns>
        public static uint GetUint(object obj)
        {
            uint uintTmp = 0;
            return uint.TryParse(GetString(obj), out uintTmp) ? uintTmp : default(uint);
        }

        /// <summary>
        /// object convert to nullable uint
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable uint, when could not convert then null</returns>
        public static uint? GetUintNull(object obj)
        {
            uint uintTmp = 0;
            return uint.TryParse(GetString(obj), out uintTmp) ? (uint?)uintTmp : null;
        }

        /// <summary>
        /// object convert to ulong
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>ulong, when could not convert then default</returns>
        public static ulong GetUlong(object obj)
        {
            ulong ulongTmp = 0;
            return ulong.TryParse(GetString(obj), out ulongTmp) ? ulongTmp : default(ulong);
        }

        /// <summary>
        /// object convert to nullable ulong
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable ulong, when could not convert then null</returns>
        public static ulong? GetUlongNull(object obj)
        {
            ulong ulongTmp = 0;
            return ulong.TryParse(GetString(obj), out ulongTmp) ? (ulong?)ulongTmp : null;
        }

        /// <summary>
        /// object convert to ushort
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>ushort, when could not convert then default</returns>
        public static ushort GetUshort(object obj)
        {
            ushort ushortTmp = 0;
            return ushort.TryParse(GetString(obj), out ushortTmp) ? ushortTmp : default(ushort);
        }

        /// <summary>
        /// object convert to nullable ushort
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable ushort, when could not convert then null</returns>
        public static ushort? GetUshortNull(object obj)
        {
            ushort ushortTmp = 0;
            return ushort.TryParse(GetString(obj), out ushortTmp) ? (ushort?)ushortTmp : null;
        }

        /// <summary>
        /// object convert to DateTime
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>DateTime, when could not convert then default</returns>
        public static DateTime GetDateTime(object obj)
        {
            DateTime DateTimeTmp = DateTime.Now;
            return DateTime.TryParse(GetString(obj), out DateTimeTmp) ? DateTimeTmp : default(DateTime);
        }

        /// <summary>
        /// object convert to nullable DateTime
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>nullable DateTime, when could not convert then null</returns>
        public static DateTime? GetDateTimeNull(object obj)
        {
            DateTime DateTimeTmp = DateTime.Now;
            return DateTime.TryParse(GetString(obj), out DateTimeTmp) ? (DateTime?)DateTimeTmp : null;
        }
    }
}

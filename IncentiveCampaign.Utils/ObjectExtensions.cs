﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace IncentiveCampaign.Utils
{
    public static class ObjectExtensions
    {
        public static int ToInt32(this object source, int defaultValue = 0)
        {
            return TryConvert(source, defaultValue, Convert.ToInt32);
        }

        public static int? ToInt32Nullable(this object source)
        {
            return TryConvert(source, null, obj => (int?)Convert.ToInt32(obj));
        }

        public static long ToInt64(this object source, long defaultValue = 0)
        {
            return TryConvert(source, defaultValue, Convert.ToInt64);
        }

        public static long? ToInt64Nullable(this object source)
        {
            return TryConvert(source, null, obj => (long?)Convert.ToInt64(obj));
        }

        public static bool ToBoolean(this object source, bool defaultValue = false)
        {
            return TryConvert(source, defaultValue, Convert.ToBoolean);
        }

        public static bool? ToBooleanNullable(this object source)
        {
            return TryConvert(source, null, obj => (bool?)Convert.ToBoolean(obj));
        }

        public static double ToDouble(this object source, double defaultValue = 0)
        {
            return TryConvert(source, defaultValue, Convert.ToDouble);
        }

        public static double? ToDoubleNullable(this object source)
        {
            return TryConvert(source, null, obj => (double?)Convert.ToDouble(obj));
        }

        public static decimal ToDecimal(this object source, decimal defaultValue = 0)
        {
            return TryConvert(source, defaultValue, Convert.ToDecimal);
        }

        public static decimal? ToDecimalNullable(this object source)
        {
            return TryConvert(source, null, obj => (decimal?)Convert.ToDecimal(obj));
        }

        public static DateTime? ToDateTime(this object source, DateTime? defaultValue = null)
        {
            var minDefaultValue = defaultValue ?? DateTime.MinValue;
            var dateTime = TryConvert(source, minDefaultValue, Convert.ToDateTime);

            if (dateTime < SqlDateTime.MinValue.Value)
                return null;

            return dateTime.ToUniversalTime().Truncate(TimeSpan.FromMilliseconds(1));
        }

        public static DateTime ToDateTime(this object source)
        {
            var minDefaultValue = DateTime.MinValue;
            var dateTime = TryConvert(source, minDefaultValue, Convert.ToDateTime);

            if (dateTime < SqlDateTime.MinValue.Value)
                return SqlDateTime.MinValue.Value;

            return dateTime.ToUniversalTime().Truncate(TimeSpan.FromMilliseconds(1));
        }

        public static DateTime Truncate(this DateTime dateTime, TimeSpan timeSpan)
        {
            if (timeSpan == TimeSpan.Zero)
                return dateTime;

            return dateTime.AddTicks(-(dateTime.Ticks % timeSpan.Ticks));
        }

        public static float ToSingle(this object source, float defaultValue = 0)
        {
            return TryConvert(source, defaultValue, Convert.ToSingle);
        }

        public static float? ToSingleNullable(this object source)
        {
            return TryConvert(source, null, obj => (float?)Convert.ToSingle(obj));
        }

        public static string ToTrimmedString(this object source, string defaultValue = "")
        {
            return TryConvert(source, defaultValue, Convert.ToString).Trim();
        }

        public static char ToChar(this object source, char defaultValue = '\0')
        {
            return TryConvert(source, defaultValue, Convert.ToChar);
        }

        public static char? ToCharNullable(this object source)
        {
            return TryConvert(source, null, obj => (char?)Convert.ToChar(obj));
        }

        public static string ToYesNoLetter(this object input, string defaultValue = "N")
        {
            if (input == null)
                return defaultValue;

            if (input is bool)
                return ((bool)input) ? "S" : "N";

            return "N";
        }

        public static TType ToNormalizedObject<TType>(this TType source)
        {
            return (TType)source.ToNormalizedObject(typeof(TType));
        }

        public static TEnum ToEnum<TEnum>(this object source) where TEnum : struct
        {
            TEnum result;
            Enum.TryParse(source.ToTrimmedString(), true, out result);
            return result;
        }

        public static TEnum ToEnum<TEnum>(this char source) where TEnum : struct
        {
            TEnum result;
            Enum.TryParse(source.ToInt32().ToString(), true, out result);
            return result;
        }

        public static List<int> ToIntList(this string ids)
        {
            var ret = new List<int>();

            string[] values = ids.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();

                int num;

                if (int.TryParse(values[i], out num))
                    ret.Add(num);
            }

            return ret;
        }

        public static object TryCast(this object source, Type type)
        {
            if (source == null)
                return null;

            if (type == typeof(int))
                return source.ToInt32();

            if (type == typeof(long))
                return source.ToInt64();

            if (type == typeof(string))
                return source.ToTrimmedString();

            if (type == typeof(bool))
                return source.ToBoolean();

            if (type == typeof(float))
                return source.ToSingle();

            if (type == typeof(double))
                return source.ToDouble();

            throw new NotSupportedException($"Cannot cast {type.Name}");
        }

        public static TType TryCast<TType>(this object source)
        {
            if (source == null)
                return default(TType);

            if (typeof(TType) == typeof(int))
                return (TType)(object)source.ToInt32();

            if (typeof(TType) == typeof(long))
                return (TType)(object)source.ToInt64();

            if (typeof(TType) == typeof(string))
                return (TType)(object)source.ToTrimmedString();

            if (typeof(TType) == typeof(bool))
                return (TType)(object)source.ToBoolean();

            if (typeof(TType) == typeof(float))
                return (TType)(object)source.ToSingle();

            if (typeof(TType) == typeof(double))
                return (TType)(object)source.ToDouble();

            throw new NotSupportedException($"Cannot cast {typeof(TType).Name}");
        }

        private static TType TryConvert<TType>(object source, TType defaultValue, Func<object, TType> method)
        {
            if (source == null)
                return defaultValue;

            if (source.Equals(DBNull.Value))
                return defaultValue;

            try
            {
                return method(source);
            }
            catch
            {
                return defaultValue;
            }
        }

        private static object ToNormalizedObject(this object source, Type type)
        {
            var target = type.CreateInstance();

            if (target == null)
                return null;

            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var propType = prop.PropertyType;
                var propValue = prop.GetValue(source);

                if (propType == typeof(string))
                    propValue = (propValue ?? "").ToTrimmedString();

                else if (!propType.IsPrimitive)
                {
                    if (propValue == null)
                        propValue = propType.CreateInstance();

                    if (propType.GetInterface("IEnumerable") == null)
                        propValue = propValue.ToNormalizedObject(propType);
                }

                prop.SetValue(target, propValue);
            }

            return target;
        }

        private static object CreateInstance(this Type type)
        {
            try
            {
                if (type.IsArray)
                    return Array.CreateInstance(type.GetElementType(), 0);

                return Activator.CreateInstance(type);
            }
            catch
            {
                return null;
            }
        }

        public static bool ToBooleanString(this string value)
        {
            if (value == "S")
                return true;

            if (value == "N")
                return false;

            return false;
        }

        public static string ToStringBoolean(this bool? value)
        {
            if (value == true)
                return "S";
            else
                return "N";
        }
    }
}

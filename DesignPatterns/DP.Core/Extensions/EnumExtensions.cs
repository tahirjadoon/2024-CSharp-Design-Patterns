using System.ComponentModel;
using System.Reflection;

namespace DP.Core.Extensions;

public static class EnumExtensions
{
    public static T ToEnum<T>(this string value) where T : struct
    {
        var result = value.ToEnumNullable<T>(true);
        if(result != null && result.HasValue) return result.Value;
        throw new ArgumentOutOfRangeException(string.Format("{0}.{1}", typeof(T), value));
    }

    public static T ToEnum<T>(this string value, T defaultEnumValue) where T : struct
    {
        var result = value.ToEnumNullable<T>(true);
        if (result != null && result.HasValue) return result.Value;
        return defaultEnumValue;
    }

    public static T? ToEnumNullable<T>(this string value, bool noMatchAsNull = true) where T : struct
    {
        if (string.IsNullOrWhiteSpace(value)) return null;

        if (Enum.TryParse(value, true, out T result))
            return result;

        // If parsing fails, try to find the enum value by its DescriptionAttribute
        foreach (var field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (field.GetCustomAttribute<DescriptionAttribute>() is DescriptionAttribute descriptionAttr &&
                string.Equals(descriptionAttr.Description, value, StringComparison.OrdinalIgnoreCase))
            {
                return (T)field.GetValue(null);
            }
        }

        if (noMatchAsNull) return null;

        throw new ArgumentOutOfRangeException(string.Format("{0}.{1}", typeof(T), value));
    }

    public static string GetEnumDescription(this Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var descriptionAttribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false)
            as DescriptionAttribute[];

        return descriptionAttribute?.Length > 0 ? descriptionAttribute[0].Description : value.ToString();
    }
}

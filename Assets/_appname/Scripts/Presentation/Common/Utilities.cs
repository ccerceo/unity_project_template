using System;
using UnityEngine;
using UnityEngine.UI;

namespace Appname.Presentation
{
    public static class Utilities
    {
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;            
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);            
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static void ApplyColor(Material mat, Color mainColor)
        {
            mainColor.a = mat.color.a;
            mat.SetColor("_Color", mainColor);
        }

        public static string GetFormattedTime(long milliseconds)
        {
            if (milliseconds < 0L) milliseconds = 0L;

            var ts = TimeSpan.FromMilliseconds(milliseconds);
            var ms = Mathf.RoundToInt(ts.Milliseconds / 10f);
            var s = ts.Seconds;
            var m = ts.Minutes;

            if (ms == 100)
            {
                ms = 0;
                s++;
            }

            if (s == 60)
            {
                s = 0;
                m++;
            }

            return string.Format("{0}:{1}:{2}", m.ToString("D2"), s.ToString("D2"), ms.ToString("D2"));
        }

        public static void SetAlpha(this Image obj, float alpha)
        {
            var color = obj.color;
            color.a = alpha;
            obj.color = color;
        }

        public static void SetAlpha(this Material obj, float alpha)
        {
            var color = obj.color;
            color.a = alpha;
            obj.color = color;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace MHR___Ass.Data.Filters
{
    public static class Filter
    {
        private static List<string> _Names;

        public static List<string> GetNames<T>()
        {
            if (_Names == null)
            {
                _Names = Enum.GetNames(typeof(T)).Select(z => z.Humanize(LetterCasing.Title)).ToList();
            }

            return _Names;
        }

        public static T GetEnumType<T>(string input)
        {
            input = input.Replace(" ", "");

            return (T)Enum.Parse(typeof(T), input, true);
        }

        public enum FilterType
        {
            FreeSlots,
            ExtraSkills,
            Defense,
            FireRes,
            WaterRes,
            ThunderRes,
            IceRes,
            DragonRes
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace MHR___Ass.Data.Filters
{
    public static class Filter
    {
        private static List<string> _Names;

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

        public static List<string> GetNames<T>()
        {
            if (_Names  == null)
            {
                _Names = Enum.GetNames(typeof(T)).Select(z=> z.Humanize(LetterCasing.Title)).ToList();
            }

            return _Names;
        }

        public static T GetEnumType<T>(string input)
        {
            input = input.Replace(" ", "");
            
            return (T)Enum.Parse(typeof(T), input, true);

        }
    }
}

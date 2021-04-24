using System.Collections.Generic;
using MHR___Ass.Data.Skills;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Charms
{
    public class Charm
    {
        private HashSet<Skill> _Skills = new HashSet<Skill>();
        private HashSet<Slot> _Slots = new HashSet<Slot>();
        public string Name { get; set; }
        public Slot? Slot1 { get; set; }
        public Slot? Slot2 { get; set; }
        public Slot? Slot3 { get; set; }
        public Skill? Skill1 { get; set; }
        public Skill? Skill2 { get; set; }
        public HashSet<Skill> GetSkills(bool refresh = false)
        {
            if (refresh || _Skills == null || _Skills.Count == 0)
            {
                _Skills = new HashSet<Skill>();
                TryAdd(_Skills, Skill1);
                TryAdd(_Skills, Skill2);
            }

            return _Skills;
        }

        public HashSet<Slot> GetSlots(bool refresh = false)
        {
            if (refresh || _Slots == null || _Slots.Count == 0)
            {
                _Slots = new HashSet<Slot>();

                TryAdd(_Slots, Slot1);
                TryAdd(_Slots, Slot2);
                TryAdd(_Slots, Slot3);
            }

            return _Slots;
        }

        private void TryAdd<T>(HashSet<T> hashset, T value)
        {
            if (value != null)
            {
                hashset.Add(value);
            }
        }
    }
}
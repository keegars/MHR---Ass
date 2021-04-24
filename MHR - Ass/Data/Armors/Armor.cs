using System;
using System.Collections.Generic;
using System.Linq;
using Force.DeepCloner;
using MHR___Ass.Data.Decorations;
using MHR___Ass.Data.Skills;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors
{
    public class Armor
    {
        private HashSet<Skill> _Skills = new HashSet<Skill>();
        private HashSet<Slot> _Slots = new HashSet<Slot>();

        private int _Small_Slots = 0;
        private int _Medium_Slots = 0;
        private int _Large_Slots = 0;
        public ArmorType ArmorType { get; set; }
        public Skill? Skill1 { get; set; }
        public Skill? Skill2 { get; set; }
        public Skill? Skill3 { get; set; }
        public Skill? Skill4 { get; set; }

        public Slot? Slot1 { get; set; }
        public Slot? Slot2 { get; set; }
        public Slot? Slot3 { get; set; }
        public ArmorSet OriginalArmorSet { get; set; }

        public Armor(ArmorSet set, ArmorType armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }

        public HashSet<Skill> GetSkills(bool refresh = false)
        {
            if (refresh || _Skills == null)
            {
                _Skills = new HashSet<Skill>();
                TryAdd(_Skills, Skill1);
                TryAdd(_Skills, Skill2);
                TryAdd(_Skills, Skill3);
                TryAdd(_Skills, Skill4);

            }

            return _Skills;
        }

        public HashSet<Slot> GetSlots(bool refresh = false)
        {
            if (refresh || _Slots == null)
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

        public void EmptyPopulatedSlots()
        {
            _Skills = null;
            _Slots = null;

            if (Slot1 != null)
            {
                Slot1.Decoration = null;
            }

            if (Slot2 != null)
            {
                Slot2.Decoration = null;
            }

            if (Slot3 != null)
            {
                Slot3.Decoration = null;
            }
        }

        public bool PopulateSlot(Decoration decoration)
        {
            if (!PopulateSlotDecoration(Slot1, decoration))
            {
                if (!PopulateSlotDecoration(Slot2, decoration))
                {
                    if (!PopulateSlotDecoration(Slot3, decoration))
                    {
                        return false;
                    }
                }
            }

            return true;          
        }

        private bool PopulateSlotDecoration(Slot slot, Decoration decoration)
        {
            if (slot != null && decoration.IsSlotCompatible(slot.Type) && slot.Decoration == null)
            {
                slot.Decoration = decoration;
                return true;
            }

            return false;
        }

        public int HasSlotTypeCount(SlotType slotType)
        {
            if (slotType == SlotType.Small)
            {
                return _Small_Slots;
            }
            else if (slotType == SlotType.Medium)
            {
                return _Medium_Slots;
            }
            else if (slotType == SlotType.Large)
            {
                return _Large_Slots;
            }

            return 0;
        }

        public Dictionary<string, int> GetSkillTotals(bool refresh = false)
        {
            var totals = new Dictionary<string, int>();

            foreach (var skill in GetSkills(refresh))
            {
                var exists = totals.ContainsKey(skill.Name);

                if (exists)
                {
                    totals[skill.Name] += skill.Value;
                }
                else
                {
                    totals.Add(skill.Name, skill.Value);
                }
            }

            foreach (var slot in GetSlots(refresh))
            {
                if (slot != null && slot.Decoration != null)
                {
                    var exists = totals.ContainsKey(slot.Decoration.Skill.Name);

                    if (exists)
                    {
                        totals[slot.Decoration.Skill.Name] += 1;
                    }
                    else
                    {
                        totals.Add(slot.Decoration.Skill.Name, 1);
                    }
                }
            }

            return totals;
        }

        public bool HasSkill(Skill skill)
        {
            return GetAllSkillNames().Any(z => z == skill.Name);
        }

        public bool HasSkills(HashSet<Skill> skills)
        {
            return GetAllSkillNames().Any(z => skills.Select(y => y.Name).Contains(z));
        }

        public int HasSkillsCount(HashSet<Skill> skills)
        {
            return GetAllSkillNames().Count(z => skills.Select(y => y.Name).Contains(z));
        }

        public int SkillTotal(Skill skill)
        {
            var skillTotal = _Skills.Where(z => z.Name == skill.Name).Select(z => z.Value).DefaultIfEmpty(0).Sum();
            var slotTotal = _Slots.Where(z => z.Decoration != null).Select(z => z.Decoration.Skill.Value).DefaultIfEmpty(0).Sum();

            return skillTotal + slotTotal;
        }

        public bool HasSlot(Decoration decoration)
        {
            return _Slots.Any(z => z.Type == decoration.Type);
        }

        public bool HasSlot(HashSet<Decoration> types)
        {
            return _Slots.Any(z => types.Select(y => y.Type).Distinct().Contains(z.Type));
        }

        public string GetEmptySlotsString()
        {
            var data = GetEmptySlots();

            return string.Join(",", data.OrderBy(z => z.Key).Select(z => z.Key + " " + z.Value));
        }

        public string GetSkillTotalString()
        {
            var data = GetSkillTotals();

            return string.Join(",", data.OrderBy(z => z.Key).Select(z => z.Key + " " + z.Value));
        }

        public Dictionary<string, int> GetEmptySlots()
        {
            var emptySlots = _Slots.Where(z => z.Decoration == null);

            var data = new Dictionary<string, int>();

            foreach (var slot in emptySlots)
            {
                var slotName = Enum.GetName(typeof(SlotType), slot.Type);
                var exists = data.ContainsKey(slotName);

                if (exists)
                {
                    data[slotName] += 1;
                }
                else
                {
                    data.Add(slotName, 1);
                }
            }

            return data;
        }

        public int GetEmptySlotsCount()
        {
            return (Slot1 != null && Slot1?.Decoration == null ? 1 : 0) + (Slot2 != null && Slot2?.Decoration == null ? 1 : 0) + (Slot3 != null && Slot3?.Decoration == null ? 1 : 0);
        }

        public HashSet<Armor> GenerateArmorCombos(HashSet<Decoration> decorations)
        {
            var tmpArmor = new List<Armor>();
            tmpArmor.Add(this.DeepClone());

            var armorList = IterateArmorSlots(tmpArmor, decorations).ToHashSet();

            return armorList;
        }

        public HashSet<Armor> GenerateArmorCombos(Decoration decoration)
        {
            var tmpArmor = new List<Armor>();
            tmpArmor.Add(this.DeepClone());

            var decorations = new HashSet<Decoration>();
            decorations.Add(decoration);

            var armorList = IterateArmorSlots(tmpArmor, decorations).ToHashSet();

            return armorList;
        }

        public Armor AddSkill(Skill skill)
        {
            if (Skill1 == null)
            {
                Skill1 = skill;
                _Skills.Add(Skill1);
            }
            else if (Skill2 == null)
            {
                Skill2 = skill;
                _Skills.Add(Skill2);
            }
            else if (Skill3 == null)
            {
                Skill3 = skill;
                _Skills.Add(Skill3);
            }
            else if (Skill4 == null)
            {
                Skill4 = skill;
                _Skills.Add(Skill4);
            }
            else
            {
                throw new Exception("Trying to add too many skills!!!!");
            }

            return this;
        }

        public Armor AddSlot(Slot slot)
        {
            if (Slot1 == null)
            {
                Slot1 = slot;
                _Slots.Add(Slot1);
            }
            else if (Slot2 == null)
            {
                Slot2 = slot;
                _Slots.Add(Slot2);
            }
            else if (Slot3 == null)
            {
                Slot3 = slot;
                _Slots.Add(Slot3);
            }
            else
            {
                throw new Exception("Trying to add too many slots!!!!!");
            }

            switch (slot.Type)
            {
                case SlotType.Small:
                    _Small_Slots++;
                    break;
                case SlotType.Medium:
                    _Medium_Slots++;
                    break;
                case SlotType.Large:
                    _Large_Slots++;
                    break;
            }

            return this;
        }

        private List<string> GetSkillNames()
        {
            return GetSkills().Select(z => z.Name).Distinct().ToList();
        }

        private List<string> GetSlotSkillNames()
        {
            return GetSlots().Where(z => z.Decoration != null).Select(z => z.Decoration?.Skill.Name).Distinct().ToList();
        }

        private List<string> GetAllSkillNames()
        {
            return GetSkillNames().Concat(GetSlotSkillNames()).Distinct().ToList();
        }

        private List<Armor> IterateArmorSlots(List<Armor> armors, HashSet<Decoration> decorations)
        {
            if (Slot1 != null)
            {
                var count = armors.Count;
                for (var i = 0; i < count; i++)
                {
                    armors.AddRange(PopulateSlot(1, armors[i], decorations));
                }
            }

            if (Slot2 != null)
            {
                var count = armors.Count;
                for (var i = 0; i < count; i++)
                {
                    armors.AddRange(PopulateSlot(2, armors[i], decorations));
                }
            }

            if (Slot3 != null)
            {
                var count = armors.Count;
                for (var i = 0; i < count; i++)
                {
                    armors.AddRange(PopulateSlot(3, armors[i], decorations));
                }
            }

            return armors;
        }

        private List<Armor> PopulateSlot(int slot, Armor armor, HashSet<Decoration> decorations)
        {
            var armorList = new List<Armor>();

            foreach (var decoration in decorations)
            {
                var slotType = slot == 1 ? Slot1.Type : slot == 2 ? Slot2.Type : Slot3.Type;

                if (decoration.IsSlotCompatible(slotType))
                {
                    var newArmor = armor.DeepClone();

                    if (slot == 1)
                    {                        
                        newArmor.Slot1.Decoration = decoration;
                    }
                    else if (slot == 2)
                    {
                        newArmor.Slot2.Decoration = decoration;
                    }
                    else
                    {
                        newArmor.Slot3.Decoration = decoration;
                    }

                    armorList.Add(newArmor);
                }
            }

            return armorList;
        }
    }

    public class HeadArmor : Armor
    {
        public HeadArmor(ArmorSet set, ArmorType armorType = ArmorType.Head) : base(set, armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }
    }

    public class TorsoArmor : Armor
    {
        public TorsoArmor(ArmorSet set, ArmorType armorType = ArmorType.Torso) : base(set, armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }
    }

    public class ArmArmor : Armor
    {
        public ArmArmor(ArmorSet set, ArmorType armorType = ArmorType.Arm) : base(set, armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }
    }

    public class WaistArmor : Armor
    {
        public WaistArmor(ArmorSet set, ArmorType armorType = ArmorType.Waist) : base(set, armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }
    }

    public class LegArmor : Armor
    {
        public LegArmor(ArmorSet set, ArmorType armorType = ArmorType.Leg) : base(set, armorType)
        {
            ArmorType = armorType;
            OriginalArmorSet = set;
        }
    }
}
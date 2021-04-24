using System.Collections.Generic;
using System.Linq;
using MHR___Ass.Data.Charms;
using MHR___Ass.Data.Decorations;
using MHR___Ass.Data.Resistances;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors
{
    public class ArmorSet
    {
        private Dictionary<string, int> _SkillTotals;
        private Dictionary<string, int> _SlotTotals;
        private List<Slot> _WeaponSlots;

        public string Name { get; set; } = string.Empty;

        public int BaseDefense { get; set; } = 0;
        public Resistance Fire { get; set; } = new FireResistance();
        public Resistance Ice { get; set; } = new IceResistance();
        public Resistance Thunder { get; set; } = new ThunderResistance();
        public Resistance Water { get; set; } = new WaterResistance();
        public Resistance Dragon { get; set; } = new DragonResistance();

        public ArmorRank ArmorRank { get; set; } = ArmorRank.Low;

        public Armor? Head { get; set; }
        public Armor? Torso { get; set; }
        public Armor? Arm { get; set; }
        public Armor? Waist { get; set; }
        public Armor? Leg { get; set; }

        public Charm? Charm { get; set; }

        public ArmorSet()
        {
        }

        public ArmorSet(Armor head = null, Armor torso = null, Armor arm = null, Armor waist = null, Armor leg = null, List<Slot> weaponSlots = null, Charm charm = null)
        {
            Head = head;
            Torso = torso;
            Arm = arm;
            Waist = waist;
            Leg = leg;

            _WeaponSlots = weaponSlots;
            Charm = charm;
        }

        public void EmptyWeaponSlots()
        {
            foreach (var slot in _WeaponSlots)
            {
                slot.Decoration = null;
            }
        }

        public void EmptyCharmSlots()
        {
            if (Charm != null)
            {
                if (Charm.Slot1 != null)
                {
                    Charm.Slot1.Decoration = null;
                }

                if (Charm.Slot2 != null)
                {
                    Charm.Slot2.Decoration = null;
                }

                if (Charm.Slot3 != null)
                {
                    Charm.Slot3.Decoration = null;
                }
            }
        }

        public int GetSlotTypeCountAll(SlotType slotType)
        {
            return (Head?.HasSlotTypeCount(slotType) ?? 0) +
                 (Torso?.HasSlotTypeCount(slotType) ?? 0) +
                 (Arm?.HasSlotTypeCount(slotType) ?? 0) +
                 (Waist?.HasSlotTypeCount(slotType) ?? 0) +
                 (Leg?.HasSlotTypeCount(slotType) ?? 0) +
                 (_WeaponSlots?.Count(z => z.Type == slotType) ?? 0) +
                 (Charm?.HasSlotTypeCount(slotType) ?? 0);
        }

        public void EmptyTotals()
        {
            _SkillTotals = null;
            _SlotTotals = null;
        }

        public Dictionary<string, int> GetSkillTotals(bool refresh = false)
        {
            if (_SkillTotals == null || refresh)
            {
                var totals = new Dictionary<string, int>();

                var headTotals = Head?.GetSkillTotals(refresh) ?? new Dictionary<string, int>();
                var torsoTotals = Torso?.GetSkillTotals(refresh) ?? new Dictionary<string, int>();
                var armTotals = Arm?.GetSkillTotals(refresh) ?? new Dictionary<string, int>();
                var waistTotals = Waist?.GetSkillTotals(refresh) ?? new Dictionary<string, int>();
                var legTotals = Leg?.GetSkillTotals(refresh) ?? new Dictionary<string, int>();

                var weaponTotals = _WeaponSlots?.GetSkillTotals() ?? new Dictionary<string, int>();
                var charmTotals = Charm?.GetSkillTotals() ?? new Dictionary<string, int>();

                TryAddRange(totals, headTotals);
                TryAddRange(totals, torsoTotals);
                TryAddRange(totals, armTotals);
                TryAddRange(totals, waistTotals);
                TryAddRange(totals, legTotals);
                TryAddRange(totals, weaponTotals);
                TryAddRange(totals, charmTotals);

                _SkillTotals = totals;
            }

            return _SkillTotals;
        }

        public Dictionary<string, int> GetSlotTotals(bool refresh = false)
        {
            if (_SlotTotals == null || refresh)
            {
                var totals = new Dictionary<string, int>();

                var headSlots = Head?.GetSlots(refresh) ?? new HashSet<Slots.Slot>();
                var torsoSlots = Torso?.GetSlots(refresh) ?? new HashSet<Slots.Slot>();
                var armSlots = Arm?.GetSlots(refresh) ?? new HashSet<Slots.Slot>();
                var waistSlots = Waist?.GetSlots(refresh) ?? new HashSet<Slots.Slot>();
                var legSlots = Leg?.GetSlots(refresh) ?? new HashSet<Slots.Slot>();

                var weaponSlots = _WeaponSlots.ToHashSet();
                var charmSlots = Charm?.GetSlots(refresh) ?? new HashSet<Slot>();

                TryAddRange(totals, headSlots);
                TryAddRange(totals, torsoSlots);
                TryAddRange(totals, armSlots);
                TryAddRange(totals, waistSlots);
                TryAddRange(totals, legSlots);
                TryAddRange(totals, weaponSlots);
                TryAddRange(totals, charmSlots);

                _SlotTotals = totals;
            }

            return _SlotTotals;
        }

        public int GetDefense(ArmorType armorType)
        {
            var armor = GetArmor(armorType);
            return armor == null ? 0 : armor.OriginalArmorSet.BaseDefense;
        }

        public HashSet<SlotCombo> GetSlotCombos()
        {
            var slotCombos = new HashSet<SlotCombo>();

            var slotTotals = GetSlotTotals();

            if (slotTotals.Count != 0)
            {
                var smallParsed = slotTotals.TryGetValue("Small Slot", out var small);
                var mediumParsed = slotTotals.TryGetValue("Medium Slot", out var medium);
                var largeParsed = slotTotals.TryGetValue("Large Slot", out var large);

                if (smallParsed)
                {
                    slotCombos.Add(new SlotCombo(small));
                }

                if (mediumParsed)
                {
                    slotCombos.Add(new SlotCombo(small + medium));
                    slotCombos.Add(new SlotCombo(small, medium));
                }

                if (largeParsed)
                {
                    slotCombos.Add(new SlotCombo(small + medium + large));
                    slotCombos.Add(new SlotCombo(small, medium + large));
                    slotCombos.Add(new SlotCombo(small, medium, large));
                }
            }

            return slotCombos;
        }

        public void TryPopulateSlot(Decoration decoration, SlotCombo slotCombo)
        {
            for (var i = 1; i <= slotCombo.Large + slotCombo.Medium + slotCombo.Small; i++)
            {
                if (Head?.PopulateSlot(decoration) == false)
                {
                    if (Torso?.PopulateSlot(decoration) == false)
                    {
                        if (Waist?.PopulateSlot(decoration) == false)
                        {
                            if (Arm?.PopulateSlot(decoration) == false)
                            {
                                if (Leg?.PopulateSlot(decoration) == false)
                                {
                                    if (_WeaponSlots?.PopulateSlot(decoration) == false)
                                    {
                                        if (Charm?.PopulateSlot(decoration) == false)
                                        {
                                            throw new System.Exception("Couldn't add decoration!");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int GetTotalDefense()
        {
            return GetDefense(ArmorType.Head) + GetDefense(ArmorType.Arm) + GetDefense(ArmorType.Torso) + GetDefense(ArmorType.Waist) + GetDefense(ArmorType.Leg);
        }

        public int GetFreeSlots()
        {
            return (Head?.GetEmptySlotsCount() ?? 0) +
                (Torso?.GetEmptySlotsCount() ?? 0) +
                (Arm?.GetEmptySlotsCount() ?? 0) +
                (Waist?.GetEmptySlotsCount() ?? 0) +
                (Leg?.GetEmptySlotsCount() ?? 0) +
                (_WeaponSlots?.Count(z => z.Decoration == null) ?? 0) +
                (Charm?.GetEmptySlotsCount() ?? 0);
        }

        public List<Slot> GetWeaponSlots()
        {
            return _WeaponSlots;
        }

        public int GetTotalResistance(ResistanceType resistanceType)
        {
            switch (resistanceType)
            {
                case ResistanceType.Fire:
                    return Head.OriginalArmorSet.Fire.Value + Torso.OriginalArmorSet.Fire.Value + Arm.OriginalArmorSet.Fire.Value + Waist.OriginalArmorSet.Fire.Value + Leg.OriginalArmorSet.Fire.Value;
                case ResistanceType.Ice:
                    return Head.OriginalArmorSet.Ice.Value + Torso.OriginalArmorSet.Ice.Value + Arm.OriginalArmorSet.Ice.Value + Waist.OriginalArmorSet.Ice.Value + Leg.OriginalArmorSet.Ice.Value;
                case ResistanceType.Thunder:
                    return Head.OriginalArmorSet.Thunder.Value + Torso.OriginalArmorSet.Thunder.Value + Arm.OriginalArmorSet.Thunder.Value + Waist.OriginalArmorSet.Thunder.Value + Leg.OriginalArmorSet.Thunder.Value;
                case ResistanceType.Water:
                    return Head.OriginalArmorSet.Water.Value + Torso.OriginalArmorSet.Water.Value + Arm.OriginalArmorSet.Water.Value + Waist.OriginalArmorSet.Water.Value + Leg.OriginalArmorSet.Water.Value;
                case ResistanceType.Dragon:
                    return Head.OriginalArmorSet.Dragon.Value + Torso.OriginalArmorSet.Dragon.Value + Arm.OriginalArmorSet.Dragon.Value + Waist.OriginalArmorSet.Dragon.Value + Leg.OriginalArmorSet.Dragon.Value;
            }

            return 0;
        }

        public Armor GetArmor(ArmorType armorType)
        {
            switch (armorType)
            {
                case ArmorType.Head:
                    return Head;
                case ArmorType.Torso:
                    return Torso;
                case ArmorType.Arm:
                    return Arm;
                case ArmorType.Waist:
                    return Waist;
                case ArmorType.Leg:
                    return Leg;
            }

            return null;
        }

        private void TryAddRange(Dictionary<string, int> dictionary, Dictionary<string, int> dictionary2)
        {
            foreach (var value in dictionary2)
            {
                var exists = dictionary.ContainsKey(value.Key);

                if (exists)
                {
                    dictionary[value.Key] += value.Value;
                }
                else
                {
                    dictionary.Add(value.Key, value.Value);
                }
            }
        }

        private void TryAddRange(Dictionary<string, int> dictionary, HashSet<Slots.Slot> slots)
        {
            foreach (var slot in slots)
            {
                var key = "";
                var value = 1;

                if (slot.Decoration == null)
                {
                    key = slot.Type == SlotType.Large ? "Large Slot" : slot.Type == SlotType.Medium ? "Medium Slot" : "Small Slot";
                }
                else
                {
                    key = slot.Decoration.Name;
                }

                var exists = dictionary.ContainsKey(key);

                if (exists)
                {
                    dictionary[key] += value;
                }
                else
                {
                    dictionary.Add(key, value);
                }
            }
        }
    }
}
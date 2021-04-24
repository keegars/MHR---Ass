using System.Collections.Generic;
using System.Linq;
using MHR___Ass.Data.Armors.Sets;
using MHR___Ass.Data.Charms;
using MHR___Ass.Data.Decorations;
using MHR___Ass.Data.Resistances;
using MHR___Ass.Data.Skills;
using MHR___Ass.Data.Slots;
using static MHR___Ass.Data.Filters.Filter;

namespace MHR___Ass.Data.Armors
{
    public static class ArmorHelper
    {
        public static HashSet<Armor> FilterOn(this HashSet<ArmorSet> armorSet, ArmorType armorType, HashSet<Skill> skills)
        {
            return armorSet.Select(z => z.GetArmor(armorType)).Where(z => z?.HasSkills(skills) ?? false).ToHashSet();
        }

        public static HashSet<Armor> FilterOn(this HashSet<ArmorSet> armorSet, ArmorType armorType, HashSet<Decoration> decorations)
        {
            return armorSet.Select(z => z.GetArmor(armorType)).Where(z => z?.HasSlot(decorations) ?? false).ToHashSet();
        }

        public static HashSet<SlotGrouping> GroupBySlots(this HashSet<Armor> armors)
        {
            var groupBySlots = armors.GroupBy(z => new
            {
                Small = z.HasSlotTypeCount(SlotType.Small),
                Medium = z.HasSlotTypeCount(SlotType.Medium),
                Large = z.HasSlotTypeCount(SlotType.Large)
            })
            .Select(y => new SlotGrouping
            {
                Slots = new SlotDetail
                {
                    Small = y.Key.Small,
                    Medium = y.Key.Medium,
                    Large = y.Key.Large
                },
                Armor = y.Select(x => x).ToList()
            }).ToHashSet();

            return groupBySlots;
        }

        public static HashSet<Armor> FilterByBest(this HashSet<SlotGrouping> slotGroupings, FilterType filterType = FilterType.Defense)
        {
            return slotGroupings.Select(z => z.Armor.OrderBy(filterType).First()).ToHashSet();
        }

        public static IOrderedEnumerable<Armor> OrderBy(this IEnumerable<Armor> armors, FilterType filterType)
        {
            switch (filterType)
            {
                default:
                case FilterType.FreeSlots:
                    return armors.OrderByDescending(z => z.GetEmptySlotsCount());
                case FilterType.ExtraSkills:
                    return armors.OrderByDescending(z => z.GetSkillTotals().Count);
                case FilterType.Defense:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.BaseDefense);
                case FilterType.FireRes:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.Fire);
                case FilterType.WaterRes:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.Water);
                case FilterType.ThunderRes:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.Thunder);
                case FilterType.IceRes:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.Ice);
                case FilterType.DragonRes:
                    return armors.OrderByDescending(z => z.OriginalArmorSet.Dragon);
            }
        }

        public static IOrderedEnumerable<ArmorSet> OrderBy(this IEnumerable<ArmorSet> armors, FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.FreeSlots:
                    return armors.OrderByDescending(z => z.GetFreeSlots());
                case FilterType.ExtraSkills:
                    return armors.OrderByDescending(z => z.GetSkillTotals().Count);
                case FilterType.Defense:
                    return armors.OrderByDescending(z => z.GetTotalDefense());
                case FilterType.FireRes:
                    return armors.OrderByDescending(z => z.GetTotalResistance(ResistanceType.Fire));
                case FilterType.WaterRes:
                    return armors.OrderByDescending(z => z.GetTotalResistance(ResistanceType.Water));
                case FilterType.ThunderRes:
                    return armors.OrderByDescending(z => z.GetTotalResistance(ResistanceType.Thunder));
                case FilterType.IceRes:
                    return armors.OrderByDescending(z => z.GetTotalResistance(ResistanceType.Ice));
                case FilterType.DragonRes:
                    return armors.OrderByDescending(z => z.GetTotalResistance(ResistanceType.Dragon));
            }

            return armors.OrderByDescending(z => z.GetFreeSlots());
        }

        public static Dictionary<string, int> GetSkillTotals(this List<Slot> slots)
        {
            var totals = new Dictionary<string, int>();

            foreach (var slot in slots)
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

        public static Dictionary<string, int> GetSkillTotals(this Charm charm, bool refresh = false)
        {
            var totals = new Dictionary<string, int>();

            foreach (var skill in charm.GetSkills(refresh))
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

            foreach (var slot in charm.GetSlots(refresh))
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

        public static void AddNakedArmor(HashSet<Armor> headArmor, HashSet<Armor> torsoArmor, HashSet<Armor> armArmor, HashSet<Armor> waistArmor, HashSet<Armor> legArmor)
        {
            var nakedArmor = new Naked();

            headArmor.Add(nakedArmor.Head);
            torsoArmor.Add(nakedArmor.Torso);
            armArmor.Add(nakedArmor.Arm);
            waistArmor.Add(nakedArmor.Waist);
            legArmor.Add(nakedArmor.Leg);
        }

        public static IEnumerable<ArmorSet> GenerateArmorSets(HashSet<Armor> headArmor, HashSet<Armor> torsoArmor, HashSet<Armor> armArmor, HashSet<Armor> waistArmor, HashSet<Armor> legArmor, List<Slot> weaponSlots, Charm charm)
        {
            foreach (var head in headArmor)
            {
                foreach (var torso in torsoArmor)
                {
                    foreach (var arm in armArmor)
                    {
                        foreach (var waist in waistArmor)
                        {
                            foreach (var leg in legArmor)
                            {
                                yield return new ArmorSet(head, torso, arm, waist, leg, weaponSlots, charm);
                            }
                        }
                    }
                }
            }
        }

        public static void EmptyPopulatedSlots(this ArmorSet armorSet)
        {
            armorSet.GetArmor(ArmorType.Head)?.EmptyPopulatedSlots();
            armorSet.GetArmor(ArmorType.Torso)?.EmptyPopulatedSlots();
            armorSet.GetArmor(ArmorType.Arm)?.EmptyPopulatedSlots();
            armorSet.GetArmor(ArmorType.Waist)?.EmptyPopulatedSlots();
            armorSet.GetArmor(ArmorType.Leg)?.EmptyPopulatedSlots();
            armorSet.EmptyWeaponSlots();
            armorSet.EmptyCharmSlots();
            armorSet.EmptyTotals();
        }

        public static HashSet<Armor> FilterByRank(this HashSet<Armor> armors, HashSet<ArmorRank> armorRanks)
        {
            return armors.Where(z => armorRanks.Contains(z.OriginalArmorSet.ArmorRank)).ToHashSet();
        }

        public static bool PopulateSlot(this List<Slot> slotList, Decoration decoration)
        {
            foreach (var slot in slotList)
            {
                if (slot != null && decoration.IsSlotCompatible(slot.Type) && slot.Decoration == null)
                {
                    slot.Decoration = decoration;
                    return true;
                }
            }

            return false;
        }

        public static int GetEmptySlotsCount(this Charm charm)
        {
            return (charm.Slot1 != null && charm.Slot1?.Decoration == null ? 1 : 0) + (charm.Slot2 != null && charm.Slot2?.Decoration == null ? 1 : 0) + (charm.Slot3 != null && charm.Slot3?.Decoration == null ? 1 : 0);
        }

        public static bool PopulateSlot(this Charm charm, Decoration decoration)
        {
            if (!PopulateSlotDecoration(charm.Slot1, decoration))
            {
                if (!PopulateSlotDecoration(charm.Slot2, decoration))
                {
                    if (!PopulateSlotDecoration(charm.Slot3, decoration))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int HasSlotTypeCount(this Charm charm, SlotType slotType)
        {
            if (charm == null)
            {
                return 0;
            }
            else
            {
                return (charm?.Slot1?.Type == slotType ? 1 : 0) +
                    (charm?.Slot2?.Type == slotType ? 1 : 0) +
                    (charm?.Slot3?.Type == slotType ? 1 : 0);
            }
        }

        private static bool PopulateSlotDecoration(Slot slot, Decoration decoration)
        {
            if (slot != null && decoration.IsSlotCompatible(slot.Type) && slot.Decoration == null)
            {
                slot.Decoration = decoration;
                return true;
            }

            return false;
        }
    }

    public class SlotGrouping
    {
        public SlotDetail Slots { get; set; }
        public IEnumerable<Armor> Armor { get; set; }
    }

    public class SlotDetail
    {
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
    }
}
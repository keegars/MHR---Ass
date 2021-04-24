using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ChromeMetal : ArmorSet
    {
        public ChromeMetal()
        {
            Name = "Chrome Metal";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 46;
            Fire.Value = -2;
            Water.Value = -2;
            Ice.Value = -2;
            Thunder.Value = -2;
            Dragon.Value = -2;

            //Armor skills/slots

            Waist = new WaistArmor(this)
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new FlinchFree(2))
                .AddSlot(new LargeSlot());
        }
    }
}
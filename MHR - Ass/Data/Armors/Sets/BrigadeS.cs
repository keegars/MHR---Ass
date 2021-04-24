using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BrigadeS : ArmorSet
    {
        public BrigadeS()
        {
            Name = "Brigade S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 62;
            Fire.Value = 1;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 2;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Botanist(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CaptureMaster(1))
                .AddSkill(new Geologist(1))
                .AddSlot(new SmallSlot());
        }
    }
}
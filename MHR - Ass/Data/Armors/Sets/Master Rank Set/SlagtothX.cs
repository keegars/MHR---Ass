using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SlagtothX : ArmorSet
    {
        public SlagtothX()
        {
            Name = "Slagtoth X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 100;
            Fire.Value = -2;
            Water.Value = 2;
            Ice.Value = -1;
            Thunder.Value = 0;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new FreeMeal(1))
                .AddSkill(new Diversion(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new FreeMeal(2))
                .AddSkill(new ItemProlonger(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}
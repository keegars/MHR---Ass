using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SinisterS : ArmorSet
    {
        public SinisterS()
        {
            Name = "Sinister S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 64;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Resentment(1))
                .AddSkill(new Handicraft(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSkill(new Handicraft(2))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSkill(new Resentment(1))
                .AddSkill(new FlinchFree(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}
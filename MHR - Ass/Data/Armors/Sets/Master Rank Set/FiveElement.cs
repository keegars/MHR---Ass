using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class FiveElement : ArmorSet
    {
        public FiveElement()
        {
            Name = "Five Element";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 108;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new HellfireCloak(2))
                .AddSkill(new MindsEye(2))
                .AddSkill(new Ballistics(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new BlightResistance(1))
                .AddSkill(new MindsEye(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new DivineBlessing(1))
                .AddSkill(new Ballistics(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new BlightResistance(2))
                .AddSkill(new MasterMounter(2))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new DivineBlessing(2))
                .AddSkill(new HellfireCloak(2))
                .AddSlot(new LargeSlot());
        }
    }
}
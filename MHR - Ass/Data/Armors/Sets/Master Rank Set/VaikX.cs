using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class VaikX : ArmorSet
    {
        public VaikX()
        {
            Name = "Vaik X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 108;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = -1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AmmoUp(2))
                .AddSkill(new RecoverySpeed(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new HungerResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new NormalRapidUp(2))
                .AddSkill(new HungerResistance(2))
                .AddSkill(new RazorSharp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSkill(new HungerResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}
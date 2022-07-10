using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BazelgeuseX : ArmorSet
    {
        public BazelgeuseX()
        {
            Name = "Bazelgeuse X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 136;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = -2;
            Thunder.Value = -4;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Artillery(1))
                .AddSkill(new Guard(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new LargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new GuardUp(2))
                .AddSkill(new Agitator(2))
                .AddSkill(new RazorSharp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new GuardUp(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new LoadShells(2))
                .AddSkill(new Guard(2))
                .AddSkill(new RazorSharp(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Artillery(2))
                .AddSkill(new Guard(2))
                .AddSkill(new Agitator(2))
                .AddSlot(new LargeSlot());
        }
    }
}
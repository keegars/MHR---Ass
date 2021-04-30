using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Bazel : ArmorSet
    {
        public Bazel()
        {
            Name = "Bazel";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = 1;
            Ice.Value = -2;
            Thunder.Value = -4;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
              .AddSlot(new MediumSlot())
              .AddSkill(new Artillery(1))
              .AddSkill(new Guard(1));

            Torso = new TorsoArmor(this)
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSkill(new GuardUp(2))
                .AddSkill(new Agitator(1));

            Arm = new ArmArmor(this)
              .AddSlot(new MediumSlot())
              .AddSlot(new MediumSlot())
              .AddSkill(new LoadShells(1))
              .AddSkill(new GuardUp(1));

            Waist = new WaistArmor(this)
              .AddSlot(new MediumSlot())
              .AddSlot(new MediumSlot())
              .AddSkill(new LoadShells(1))
              .AddSkill(new Guard(1));

            Leg = new LegArmor(this)
              .AddSlot(new LargeSlot())
              .AddSkill(new Artillery(2))
              .AddSkill(new Guard(1));
        }
    }
}
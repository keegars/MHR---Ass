using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ZinogreS : ArmorSet
    {
        public ZinogreS()
        {
            Name = "Zinogre S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 62;
            Fire.Value = 0;
            Water.Value = -1;
            Ice.Value = -4;
            Thunder.Value = 4;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new Constitution(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new LatentPower(1))
                .AddSkill(new Constitution(2))
                .AddSlot(new SmallSlot());
        }
    }
}
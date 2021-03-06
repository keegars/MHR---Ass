using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BasariosS : ArmorSet
    {
        public BasariosS()
        {
            Name = "Basarios S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 82;
            Fire.Value = 0;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new LoadShells(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new SpeedSharpening(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedSharpening(2))
                .AddSkill(new DefenseBoost(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new DefenseBoost(1))
                .AddSlot(new LargeSlot());
        }
    }
}
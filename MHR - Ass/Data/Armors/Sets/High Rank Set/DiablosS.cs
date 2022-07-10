using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DiablosS : ArmorSet
    {
        public DiablosS()
        {
            Name = "Diablos S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 84;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = -3;
            Thunder.Value = -1;
            Dragon.Value = -1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new StaminaSurge(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new OffensiveGuard(2))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new StaminaSurge(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Guard(1))
                .AddSkill(new OffensiveGuard(1))
                .AddSlot(new MediumSlot());
        }
    }
}
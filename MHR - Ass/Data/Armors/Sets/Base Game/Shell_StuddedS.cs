using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Shell_StuddedS : ArmorSet
    {
        public Shell_StuddedS()
        {
            Name = "Shell-Studded S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = 0;
            Water.Value = 2;
            Ice.Value = -1;
            Thunder.Value = 1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Ballistics(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new NormalRapidUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Ballistics(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new SpreadUp(1))
                .AddSkill(new PierceUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}
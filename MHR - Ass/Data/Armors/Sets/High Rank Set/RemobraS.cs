using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class RemobraS : ArmorSet
    {
        public RemobraS()
        {
            Name = "Remobra S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Windproof(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalElement(1))
                .AddSkill(new Windproof(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalElement(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WeaknessExploit(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}
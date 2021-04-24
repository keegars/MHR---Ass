using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class TigrexS : ArmorSet
    {
        public TigrexS()
        {
            Name = "Tigrex S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 64;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Earplugs(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Earplugs(2))
                .AddSkill(new Bludgeoner(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Bludgeoner(2))
                .AddSkill(new MindsEye(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Earplugs(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new SpeedEating(2))
                .AddSkill(new MindsEye(1))
                .AddSlot(new SmallSlot());
        }
    }
}
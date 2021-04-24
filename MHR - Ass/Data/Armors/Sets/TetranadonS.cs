using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class TetranadonS : ArmorSet
    {
        public TetranadonS()
        {
            Name = "Tetranadon S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 40;
            Fire.Value = -1;
            Water.Value = 4;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new SpeedEating(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Heroics(1))
                .AddSkill(new SpecialAmmoBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(2))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSkill(new HungerResistance(1))
                .AddSlot(new SmallSlot());
        }
    }
}
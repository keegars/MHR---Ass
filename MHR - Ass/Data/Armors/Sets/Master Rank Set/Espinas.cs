using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Espinas : ArmorSet
    {
        public Espinas()
        {
            Name = "Espinas";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 132;
            Fire.Value = 3;
            Water.Value = -1;
            Ice.Value = 0;
            Thunder.Value = -3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new ParalysisAttack(3))
                .AddSkill(new Partbreaker(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Foray(1))
                .AddSkill(new Partbreaker(1))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Foray(1))
                .AddSkill(new ProtectivePolish(1))
                .AddSkill(new RapidFireUp(1))
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Agitator(2))
                .AddSkill(new ProtectivePolish(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Foray(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new PoisonAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}
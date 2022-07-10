using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class DoberX : ArmorSet
    {
        public DoberX()
        {
            Name = "Dober X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 112;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 4;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new AttackBoost(1))
                .AddSkill(new Heroics(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new Focus(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new Heroics(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new RecoilDown(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new AttackBoost(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new DragonAttack(1))
                .AddSkill(new Focus(1))
                .AddSkill(new Heroics(1))
                .AddSlot(new MediumSlot());
        }
    }
}
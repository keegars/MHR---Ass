using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BasariosX : ArmorSet
    {
        public BasariosX()
        {
            Name = "Basarios X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 108;
            Fire.Value = 0;
            Water.Value = -2;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = -3;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new Artillery(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Guard(2))
                .AddSkill(new LoadShells(2))
                .AddSkill(new LatentPower(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new Guard(3))
                .AddSkill(new SpeedSharpening(3))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new SpeedSharpening(2))
                .AddSkill(new DefenseBoost(2))
                .AddSkill(new LatentPower(2))
                .AddSkill(new ReloadSpeed(2))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new LoadShells(1))
                .AddSkill(new DefenseBoost(1))
                .AddSkill(new LatentPower(1))
                .AddSkill(new ReloadSpeed(1))
                .AddSlot(new LargeSlot());
        }
    }
}
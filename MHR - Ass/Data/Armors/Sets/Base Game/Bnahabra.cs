using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Bnahabra : ArmorSet
    {
        public Bnahabra()
        {
            Name = "Bnahabra";

            //Base values
            BaseDefense = 14;
            Fire.Value = -2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RecoilDown(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new ParalysisAttack(1));

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1));

            Waist = new WaistArmor(this)
                .AddSkill(new ParalysisAttack(1));

            Leg = new LegArmor(this)
                .AddSkill(new RecoilDown(1));
        }
    }
}
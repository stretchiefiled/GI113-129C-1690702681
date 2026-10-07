namespace WEEK2
{
    /*
* Student ID : 1690702681
* Name       : วรัทยา ปานทอง
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
    internal class BossProgram
    {
        public static void Run()
        {
            // Boss information
            string name = "Kirin";
            char rank = 'S';
            int level = 7;
            int currentHp = 175;
            int maxHp = 240;
            float attackPower = 42.5f;
            float critMultiplier = 1.75f;
            bool isBoss = true;

            // Calculate HP percentage
            int hpPercent = currentHp * 100 / maxHp;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            // Damage
            int damage = 60;
            currentHp -= damage;

            Console.WriteLine($"Kirin takes {damage} damage!");
            Console.WriteLine();

            // Calculate HP percentage after damage
            hpPercent = currentHp * 100 / maxHp;

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {hpPercent}%");



            // Tank information
            string tankName = "Tanker";
            char tankRank = 'A';
            int tankLevel = 5;
            int tankCurrentHp = 200;
            int tankMaxHp = 250;
            float tankAttackPower = 42.5f;
            float tankCritMultiplier = 1.75f;
            bool tankIsBoss = true;

            // Calculate HP percentage
            int tankHpPercent = tankCurrentHp * 100 / tankMaxHp;

            Console.WriteLine("===== TANK STATUS: INITIAL =====");
            Console.WriteLine($"Name: {tankName}");
            Console.WriteLine($"Rank: {tankRank}");
            Console.WriteLine($"Level: {tankLevel}");
            Console.WriteLine($"HP: {tankCurrentHp} / {tankMaxHp}");
            Console.WriteLine($"Attack Power: {tankAttackPower}");
            Console.WriteLine($"Crit Multiplier: {tankCritMultiplier}");
            Console.WriteLine($"Is Boss: {tankIsBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {tankHpPercent}%");
            Console.WriteLine();
            tankCurrentHp -= damage;

            Console.WriteLine($"Tanker takes {damage} damage!");
            Console.WriteLine();

            // Calculate HP percentage after damage
            tankHpPercent = tankCurrentHp * 100 / tankMaxHp;

            Console.WriteLine("===== TANK STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {tankCurrentHp} / {tankMaxHp}");
            Console.WriteLine($"HP Percent: {tankHpPercent}%");

            // Mage information 
            string mageName = "Mage";
            char mageRank = 'S';
            int mageLevel = 7;
            int mageCurrentHp = 175;
            int mageMaxHp = 240;
            float mageAttackPower = 42.5f;
            float mageCritMultiplier = 1.75f;
            bool mageIsBoss = true;
            // Calculate HP percentage
            int mageHpPercent = mageCurrentHp * 100 / mageMaxHp;
            Console.WriteLine("===== MAGE STATUS: INITIAL =====");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Level: {mageLevel}");
            Console.WriteLine($"HP: {mageCurrentHp} / {mageMaxHp}");
            Console.WriteLine($"Attack Power: {mageAttackPower}");
            Console.WriteLine($"Crit Multiplier: {mageCritMultiplier}");
            Console.WriteLine($"Is Boss: {mageIsBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {mageHpPercent}%");
            Console.WriteLine();
            // Damage for mage
            int mageDamage = 60;
            mageCurrentHp -= mageDamage;
            Console.WriteLine($"{mageName} takes {mageDamage} damage!");
            Console.WriteLine();
            // Calculate HP percentage after damage
            mageHpPercent = mageCurrentHp * 100 / mageMaxHp;
            Console.WriteLine("===== MAGE STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {mageCurrentHp} / {mageMaxHp}");
            Console.WriteLine($"HP Percent: {mageHpPercent}%");

            // Healer information
            string healerName = "Healer";
            char healerRank = 'A';
            int healerLevel = 5;
            int healerCurrentHp = 150;
            int healerMaxHp = 200;
            float healerAttackPower = 30.0f;
            float healerCritMultiplier = 1.5f;
            bool healerIsBoss = false;
            // Calculate HP percentage
            int healerHpPercent = healerCurrentHp * 100 / healerMaxHp;
            Console.WriteLine("===== HEALER STATUS: INITIAL =====");
            Console.WriteLine($"Name: {healerName}");
            Console.WriteLine($"Rank: {healerRank}");
            Console.WriteLine($"Level: {healerLevel}");
            Console.WriteLine($"HP: {healerCurrentHp} / {healerMaxHp}");
            Console.WriteLine($"Attack Power: {healerAttackPower}");
            Console.WriteLine($"Crit Multiplier: {healerCritMultiplier}");
            Console.WriteLine($"Is Boss: {healerIsBoss}");
            Console.WriteLine();
            Console.WriteLine($"HP Percent: {healerHpPercent}%");
            Console.WriteLine();
            // Damage for healer
            int healerDamage = 40;
            healerCurrentHp -= healerDamage;
            Console.WriteLine($"{healerName} takes {healerDamage} damage!");
            Console.WriteLine();
            // Calculate HP percentage after damage
            healerHpPercent = healerCurrentHp * 100 / healerMaxHp;
            Console.WriteLine("===== HEALER STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {healerCurrentHp} / {healerMaxHp}");
            Console.WriteLine($"HP Percent: {healerHpPercent}%");

            // Damage information
            string DamageName = "Damage";
            char DamageRank = 'A';
        }
    }
}


public class ArbreBois : Plantes
{
    public ArbreBois(int soif, int lumiere) : base("Arbre a Bois", true, new int[] { 2, 5 }, 9, 5, soif, 80, lumiere, 10, new string[] { "riche", "humide" }, new Bois(2))
    {
    }
    public override string[] Sprite()
    {
        if (temps > 5)
        {
            return new string[]{
                "       ▓▓▓▓▓▒      ",
                "      ░██████░     ",
                "     ▒█▒▒▒▒▒▒█░    ",
                "    ░▒▓░░░░░▒▓▒░   ",
                "    ▓▓░░░░░░░░▓▓   ",
                "   ░▒▒░░▒▒▒▒░░▒▓░  ",
                "   ▒▒░░▒▒▒▒▒▒░░▒░  ",
                "   ▓░░░▒▒▒▒▒▒░░▒▓  ",
                "  ▓▒▒▒▒▒▒▒▒▒▒░▒▒▒▓ ",
                " ░█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█ ",
                "  ▒▓▒▒▒▒▒▒▒▒▒▒▒▒▓▒ ",
                "  ▒▓▓▒▒▒▓▓▓▓▒▒▒▓▓▒ ",
                "   █▓▒█▓▒▒▒▒▓█▒▓█  ",
                "   ▒▓▒▓▓▒▒▒▒▓▓▒▓▒  ",
                "    ▓█ ▒▓▒▒▓▒░█▓   ",
                "     ░ ▒▓▒▒▓▒ ░    ",
                "       ▒▓▒▒▓▒      ",
                "       ▒▓▒▒▓▒      ",
                "       ▒▓▒▒▓▒      ",
                "       ▒▓▒▒▓▒      ",
                "      ▓▒▒▒▒▒▒▓     ",
                "     ▒▓▒▒▒▒▒▒▓░    "
            };
        }
        else if (temps < 2)
        {
            return new string[] {
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "    ░▒▒░░          ",
                "  ░▒▓▓▓▓▒  ░▒▒▒░   ",
                "       ░ ░▓▒▓▓▓▒░  ",
                "          ▓░░      ",
                "       ░░▒▓░       ",
                "     ▒▒▒▒▒▒▒▓▓▒    ",
                "     ░░░░░░░░░░    "

            };
        }
        else
        {

            return new string[] {
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "                   ",
                "      ▒▒           ",
                "     ▓▒▒▓          ",
                "    ▒▒▒▒▒▒         ",
                "    ▒▒▓▓▓▓░   ░▓   ",
                "    ░▓▒▓▓▓▓  ░▒▒▒  ",
                "     ▒▓▓▓▓▓░ ▒▒▒▒░ ",
                "      ▓▓█▓▓▒ ▓▒▓▒▒ ",
                "       ░▒░░▓░▓▓▓▓▒ ",
                "           █▓▓▓▒▓  ",
                "          ░█▓▒▓▓░  ",
                "          ░█░░▓▒   ",
                "          ░▓  ▒    ",
                "          ░▓       ",
                "          ░▓       ",
                "           █       ",
                "        ░░▒█       ",
                "       ░▓▓▓▓░▒░    ",
                "      ░▒░░░▓▓▓▓░   "

            };
        }


    }
}

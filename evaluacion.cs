void ejercicio1()
{
    int valoracion1;
    int valoracion2;
    int valoracion3;
    int valoracion4;
    string[,] red = new string[6, 3];
    string[,] green = new string[6, 3];
    string[,] blue = new string[6, 3];
    string[,] yellow = new string[6, 3];
    string[,] llenar(string[,] equipolleno)
    {
        string[] pokemones = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
        string[] tipos = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };
        Random aleatorio = new Random();
        for (int i = 0; i < equipolleno.GetLength(0); i++)
        {
            equipolleno[i, 0] = pokemones[aleatorio.Next(0, 151)];
        }
        for (int j = 0; j < equipolleno.GetLength(0); j++)
        {
            equipolleno[j, 1] = tipos[aleatorio.Next(0, 151)];
        }
        for (int o = 0; o < equipolleno.GetLength(0); o++)
        {
            equipolleno[o, 2] = aleatorio.Next(50, 80).ToString();
        }
        return equipolleno;
    }

    void mostrar(string[,] equipo)
    {
        for (int i = 0; i < equipo.GetLength(0); i++)
        {
            for (int f = 0; i < equipo.GetLength(1); i++)
            {
                Console.WriteLine(equipo[f, i] + " ");
            }
            Console.WriteLine();
        }
    }
    int valoracion(string[,] equipo)
    {
        int resultado = 0;
        for (int i = 0; i < equipo.GetLength(0); i++)
        {
            resultado = resultado + Convert.ToInt32(equipo[i, 2]);
        }
        return resultado;
    }
    red = llenar(red);
    green = llenar(green);
    blue = llenar(blue);
    yellow = llenar(yellow);
    valoracion1 = valoracion(red);
    valoracion2 = valoracion(green);
    valoracion3 = valoracion(blue);
    valoracion4 = valoracion(yellow);
    Console.WriteLine("Equipo rojo");
    mostrar(red);
    Console.WriteLine("Equipo verde");
    mostrar(green);
    Console.WriteLine("Equipo azul");
    mostrar(blue);
    Console.WriteLine("Equipo amarillo");
    mostrar(yellow);
    void ganadores()
    {
        if (valoracion(red) > valoracion(green))
        {
            Console.WriteLine("Ganó el rojo, pasa a la final");
        }
        if (valoracion(green) > valoracion(red))
        {
            Console.WriteLine("Ganó el verde, pasa a la final");
        }
        if (valoracion(blue) > valoracion(yellow))
        {
            Console.WriteLine("Ganó el azul, pasa a la final");
        }
        if (valoracion(yellow) > valoracion(blue))
        {
            Console.WriteLine("Ganó el amarillo, pasa a la final");
        }
        if (valoracion(blue) > valoracion(green))
        {
            Console.WriteLine("azul es el campeon");
        }
        else
        {
            Console.WriteLine("verde es el campeon");
        }
        if (valoracion(blue) > valoracion(red))
        {
            Console.WriteLine("azul es el campeon");
        }
        else
        {
            Console.WriteLine("rojo es el campeon");
        }
        if (valoracion(yellow) > valoracion(green))
        {
            Console.WriteLine("amarillo es el campeon");
        }
        else
        {
            Console.WriteLine("verde es el campeon");
        }
        if (valoracion(yellow) > valoracion(red))
        {
            Console.WriteLine("amarillo es el campeon");
        }
        else
        {
            Console.WriteLine("rojo es el campeon");
        }
    }
    ganadores();
}
ejercicio1();

    void recursiva(int num = 1)
    {
        if (num > 50)
        {
            return;
        }
        else
        {
            Console.WriteLine(num);
            recursiva(num + 1);
        }
    }
recursiva();
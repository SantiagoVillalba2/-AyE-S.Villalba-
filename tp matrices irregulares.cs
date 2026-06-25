string[] pokemon = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
string[] tipo = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };
string[][] blue = crearestructuraequipo();
string[][] red = crearestructuraequipo();
string[][] yellow = crearestructuraequipo();
string[][] green = crearestructuraequipo();



blue = llenarequipo(blue, "blue");
green = llenarequipo(green, "green");
red = llenarequipo(red, "red");
yellow = llenarequipo(yellow, "yellow");






string[][] ganador1 = determinarganador(red, green);
string[][] ganador2 = determinarganador(yellow, blue);
string [][] ganadorfinal;
if (ganador1 == red && ganador2 == yellow)
{
    ganadorfinal = determinarganador(red, yellow);
}
else if (ganador1 == red && ganador2 == blue)
{
    ganadorfinal = determinarganador(red, blue);
}
else if (ganador1 == green && ganador2 == yellow)
{
    ganadorfinal = determinarganador(green, yellow);
}
else
{
    ganadorfinal = determinarganador(green, blue);
}


Console.WriteLine("pelea 1 el ganador es: " + ganador1[0][0]);
Console.WriteLine("pelea 2 el ganador es: " + ganador2[0][0]);
Console.WriteLine("el ganador del torneo es: " + ganadorfinal[0][0]);
mostrar(ganadorfinal);
string[][] determinarganador(string[][] equipo1, string[][] equipo2)
{
    int nivel1 = 0;
    int nivel2 = 0;
    for (int x = 1;  x < 7; x++)
    {
        nivel1 += Convert.ToInt32(equipo1[x][2]);
        nivel2 += Convert.ToInt32(equipo2[x][2]);
    }

    if (nivel1 > nivel2)
    {
        return equipo1;
    }
    else
    {
        return equipo2;
    }

}

string[][] llenarequipo(string[][] equipo, string nombreequipo)
{
    Random aleatorio = new Random();
    equipo[0][0] = nombreequipo;

    for (int x = 1; x < 7; x++)
    {
        int eleccion = aleatorio.Next(0, 151);
        int nivel = aleatorio.Next(50, 81);
        equipo[x][0] = pokemon[eleccion];
        equipo[x][1] = tipo[eleccion];
        equipo[x][2] = nivel.ToString();
    }
    return equipo;
}

string[][] crearestructuraequipo()
{
    string[][] matriz = new string[7][];
    matriz[0] = new string[1];
    for(int i = 1; i < 7; i++)
    {
        matriz[i] = new string[3];
    }
    return matriz;
}

void mostrar(string[][] equipo)
{
    for (int x = 0; x < equipo.Length; x++)
    {
        for (int y = 0; y < equipo[x].Length; y++)
        {
            Console.Write(equipo[x][y] + " ");
        }
        Console.WriteLine();
    }
}
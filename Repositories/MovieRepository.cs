using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class MovieRepository 
    {
        public static List<Movie> Movies = new()
        {
            new() { Id =1 ,Title="Black Hawk Down",Description="The story of 160 elite U.S. soldiers who dropped into " +
                "Mogadishu in October 1993 to capture two top lieutenants of a renegade warlord, " +
                "but found themselves in a desperate battle with a large force of heavily armed Somalis.",Raiting=7.7},

            new() { Id =2 ,Title="Van Helsing",Description="The famed monster hunter is sent to Transylvania to stop Count Dracula," +
                " who is using Dr. Frankenstein's research and a werewolf for nefarious purposes.",Raiting=6.1},

            new() { Id =3 ,Title="The Dictator",Description="The heroic story of a dictator who risked his life to ensure " +
                "that democracy would never come to the country he so lovingly oppressed.",Raiting=6.4},

            new() { Id =4 ,Title="Die Hard",Description="A New York City police officer tries to save his estranged wife and several " +
                "others taken hostage by terrorists during a Christmas party at the Nakatomi Plaza in Los Angeles.",Raiting=8.2},

            new() { Id =5 ,Title="Bad Boys",Description="Two hip detectives protect a witness to a murder while investigating a case of stolen" +
                " heroin from the evidence storage room from their police precinct.",Raiting=6.8},
        };

        
    }
}

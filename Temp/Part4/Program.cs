using Part4;
using System;
using System.Numerics;
using System.Runtime.InteropServices;


List<Song> songs = new List<Song>();

Song song1 = new Song("Talking To The Moon", "I know you're somewhere out there\r\nSomewhere far away\r\nI want you back," +
        " I want you back\n...\nI know you're somewhere out there\r\nSomewhere far away");
Song song2 = new Song ("Royals", "I've never seen a diamond in the flesh\r\nI cut my teeth on wedding rings in the movies\r\n" +
        "And I'm not proud of my address\r\nIn a torn up town, no postcode envy\n...\nAnd baby, I'll rule (I'll rule," +
        " I'll rule, I'll rule)\r\nLet me live that fantasy");
Song song3 = new Song("Demons", "When the days are cold\r\nAnd the cards all fold\r\nAnd the saints we see are all made of " +
        "gold\r\nWhen your dreams all fail\r\nAnd the ones we hail\r\nAre the worst of all, and the blood's run stale" +
        "\n...\nIt's where my demons hide\r\nIt's where my demons hide");

songs.Add(song1);
songs.Add(song2);
songs.Add(song3);


Singer christinaAguilera = new Singer("Christina Aguilera");
Singer ladyGaga = new Singer("Lady Gaga");
Singer madonna = new Singer("Madonna");
Singer kesha = new Singer("Kesha");
Singer kellyClarkson = new Singer("Kelly Clarkson");
Singer shakira = new Singer("Shakira");
Singer katyPerry = new Singer("Katy Perry");
Singer adele = new Singer("Adele");
Singer rihanna = new Singer("Rihanna");
Singer britneySpears = new Singer("Britney Spears");
Singer avrilLavigne = new Singer("Avril Lavigne");
Singer beyonce = new Singer("Beyoncé");
Singer nickiMinaj = new Singer("Nicki Minaj");
Singer justinBieber = new Singer("Justin Bieber");

Singer nickCarter = new Singer("Nick Carter");
Singer howieDorough = new Singer("Howie Dorough");
Singer AJMcLean = new Singer("AJ McLean");
Singer brianLittrell = new Singer("Brian Littrell");
Singer kevinRichardson = new Singer("Kevin Richardson");

Band backstreetBoys = new Band("Backstreet Boys", nickCarter, howieDorough, AJMcLean, brianLittrell, kevinRichardson);

Singer shaneFilan = new Singer("Shane Filan");
Singer markFeehily = new Singer("Mark Feehily");
Singer kianEgan = new Singer("Kian Egan");
Singer nickyByrne = new Singer("Nicky Byrne");

Band westlife = new Band("Westlife", shaneFilan, markFeehily, kianEgan, nickyByrne);

Singer justinTimberlake = new Singer("Justin Timberlake");
Singer JCChasez = new Singer("JC Chasez");
Singer joeyFatone = new Singer("Joey Fatone");
Singer chrisKirkpatrick = new Singer("Chris Kirkpatrick");
Singer lanceBass = new Singer("Lance Bass");

Band nSync = new Band("N’ Sync", justinTimberlake, JCChasez, joeyFatone, chrisKirkpatrick, lanceBass);

Band highFive = new Band("High Five", brianLittrell, chrisKirkpatrick, nickyByrne, rihanna);

Band simplePlan = new Band("Simple Plan", kesha, justinTimberlake, lanceBass);

Band jonasBrothers = new Band("Jonas Brothers", avrilLavigne, beyonce, nickiMinaj, justinBieber);

Band theJackson5 = new Band("The Jackson 5", nickCarter, howieDorough, kianEgan, nickyByrne);

Judge simonCowell = new Judge("Simon Cowell");

Contest theVoice = new Contest(simonCowell, songs, 100, christinaAguilera, ladyGaga, madonna, kesha, britneySpears,
    kellyClarkson, shakira, katyPerry, adele, rihanna, avrilLavigne, beyonce, nickiMinaj, justinBieber, nSync, backstreetBoys,
    westlife, highFive, simplePlan, jonasBrothers, theJackson5);

theVoice.Competition();
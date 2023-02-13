using Part2;

Singer christinaAguilera = new Singer("Christina Aguilera", "Beautiful", "Every day is so wonderful\r\n" +
    "Then suddenly it's hard to breathe\r\nNow and then I get insecure\r\nFrom all the pain\r\nI'm so " +
    "ashamed\n...\nDon't you bring me down\r\nOoh, today");
Singer ladyGaga = new Singer("Lady Gaga", "Bad Romance", "Oh-oh-oh-oh-oh, oh-oh-oh-oh, oh-oh-oh\r\nCaught" +
    " in a bad romance\r\nOh-oh-oh-oh-oh, oh-oh-oh-oh, oh-oh-oh\r\nCaught in a bad romance\n...\nGaga," +
    " ooh-la-la\r\nWant your bad romance");
Singer madonna = new Singer("Madonna", "Like a Virgin", "I made it through the wilderness\r\nSomehow I made " +
    "it through\r\nDidn't know how lost I was until I found you\r\nI was beat, incomplete\r\nI'd been had, " +
    "I was sad and blue, but you made me feel\r\nYeah, you made me feel shiny and new, hoo!\n...\nOoh baby," +
    " yeah\r\nCan't you hear my heart beat, for the very first time?");
Singer kesha = new Singer("Kesha", "Take It Off", "There's a place downtown\r\nWhere the freaks all come around\r\n" +
    "It's a hole in the wall\r\nIt's a dirty free for all\r\nWhen they\n...\nWhen they take it off\r\nEverybody take it off");
Singer britneySpears = new Singer("Britney Spears", "Toxic", "Baby, can't you see I'm calling?\r\nA guy like you" +
    " should wear a warning\r\nIt's dangerous, I'm falling\n...\nIntoxicate me now, with your lovin' now\r\nI think" +
    " I'm ready now");
Singer kellyClarkson = new Singer("Kelly Clarkson", "Because Of You", "I will not make the same mistakes that you did" +
    "\r\nI will not let myself 'cause my heart so much misery\r\nI will not break the way you did\r\nYou fell so hard\r" +
    "\nI've learned the hard way, to never let it get that far\n...\nBecause of you\r\nBecause of you");
Singer shakira = new Singer("Shakira", "Hips Don't Lie", "Ladies up in here tonight\r\nNo fighting\r\nWe got the refugees" +
    " up in here (no fighting)\r\nNo fighting\r\nShakira, Shakira\n...\nNo fighting\r\nNo fighting");
Singer katyPerry = new Singer("Katy Perry", "Firework", "Do you ever feel like a plastic bag\r\nDrifting through the wind," +
    " wanting to start again?\r\nDo you ever feel, feel so paper thin\r\nLike a house of cards, one blow from cavin' in?\n...\n" +
    "Boom, boom, boom\r\nEven brighter than the moon, moon, moon");
Singer adele = new Singer("Adele", "Hello", "Hello, it's me\r\nI was wondering if after all these years you'd like to" +
    " meet\r\nTo go over everything\r\nThey say that time's supposed to heal ya, but I ain't done much healing\n...\n" +
    "But it don't matter, it clearly doesn't tear you apart anymore");
Singer rihanna = new Singer("Rihanna", "Umbrella", "Uh huh, uh huh\r\nYeah, Rihanna\r\nUh huh, uh huh\r\nGood girl gone" +
    " bad\r\nUh huh, uh huh\r\nTake three, action\r\nUh huh, uh huh, Hov\n...\nIt's pouring rain\r\nIt's pouring rain");
Singer avrilLavigne = new Singer("Avril Lavigne", "Complicated", "Uh huh, life's like this\r\nUh huh, uh huh, that's" +
    " the way it is\r\n'Cause life's like this\r\nUh huh, uh huh, that's the way it is\n...\nHonesty and promise me I'm" +
    " never gonna find you faking\r\nNo, no, no");
Singer beyonce = new Singer("Beyoncé", "Halo", "Remember those walls I built?\r\nWell, baby, they're tumbling down\r\nAnd " +
    "they didn't even put up a fight\r\nThey didn't even make a sound\n...\nI can feel your halo (halo), halo\r\nI" +
    " can see your halo (halo), halo");
Singer nickiMinaj = new Singer("Nicki Minaj", "Starships", "Uh, let's go to the beach-each\r\nLet's go get a wave\r\nThey" +
    " say what they gonna say\r\nHave a drink, clink, found the Bud Light\r\nBad bitches like me is hard to come by\n...\n" +
    "Let's do this one last time\r\nCan't stop (we're higher than a motherfucker)");
Singer justinBieber = new Singer("Justin Bieber", "Love Yourself", "For all the times that you rained on my parade\r\nAnd" +
    " all the clubs you get in using my name\r\nYou think you broke my heart, oh, girl, for goodness' sake\r\nYou think" +
    " I'm crying on my own, well, I ain't\n...\nStill holdin' on to somethin' (holdin' on, no)\r\nYou should go and " +
    "love yourself");


Judge simonCowell = new Judge("Simon Cowell");

Contest theVoice = new Contest(simonCowell, christinaAguilera, ladyGaga, madonna, kesha, britneySpears, kellyClarkson, shakira,
    katyPerry, adele, rihanna, avrilLavigne, beyonce, nickiMinaj, justinBieber);


theVoice.AllRounds();
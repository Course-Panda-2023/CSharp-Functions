using Part1;

Singer christinaAguilera = new Singer("Christina Aguilera", "Beautiful", "Every day is so wonderful\r\n" +
    "Then suddenly it's hard to breathe\r\nNow and then I get insecure\r\nFrom all the pain\r\nI'm so " +
    "ashamed\n...\nDon't you bring me down\r\nOoh, today");
Singer ladyGaga = new Singer("Lady Gaga", "Bad Romance", "Oh-oh-oh-oh-oh, oh-oh-oh-oh, oh-oh-oh\r\nCaught" +
    " in a bad romance\r\nOh-oh-oh-oh-oh, oh-oh-oh-oh, oh-oh-oh\r\nCaught in a bad romance\n...\nGaga," +
    " ooh-la-la\r\nWant your bad romance");
Judge simonCowell = new Judge("Simon Cowell");

christinaAguilera.Sing();
Console.WriteLine();
Console.WriteLine();
ladyGaga.Sing();
Console.WriteLine();
Console.WriteLine();
simonCowell.Judging(christinaAguilera, ladyGaga);
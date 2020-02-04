using Sytem;

using HulpClasses;

using HulpClasses.MeerClasses;

namespace Practice_Scope
{

    class Program
    {
        static void Main(string [] args)
        {
            Player myPlayer = new Player();

            //Openbaar, mag ik bij:
            myPlayer.getalA += 1;

            //Beschermt, mag ik niet bij:
            //myPlayer.getalB += 1;

            //Openbaar, alleen via blauwdruk (Class)
            Player.staticTekst += "I'm playing with tilt controls :D";

            //Static kan niet via instantie benaderd worden:
            //myPlayer.staticTekst += "This is a nono ):<"

            HulpClassA test = new HulpClassA();
            HulpClassB test2 = new HulpClassB();

            HulpClassX TEST = new HulpClassX();



        }
    }
}
using Urho3DNet;

namespace StarCubes.IOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            Launcher.Run(_ =>new UrhoApplication(_));
        }
    }
}
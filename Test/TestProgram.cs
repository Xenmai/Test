using System.Reflection;
using FreneticGameCore;
using Test.MainGame;

namespace Test
{
    /// <summary>
    /// Central entry class for the program.
    /// </summary>
    public class TestProgram : Program
    {
        /// <summary>
        /// The name of the game.
        /// </summary>
        public const string TGameName = "Test";

        /// <summary>
        /// The version of the game. Automatically read from file.
        /// </summary>
        public static readonly string TGameVersion = Assembly.GetCallingAssembly().GetName().Version.ToString();

        /// <summary>
        /// The description of the game version.
        /// </summary>
        public const string TGameVersionDescription = "Pre-Alpha";

        public TestProgram()
            : base(TGameName, TGameVersion, TGameVersionDescription)
        {
        }

        /// <summary>
        /// Main entry method.
        /// </summary>
        /// <param name="args">Command line arguments, if any.</param>
        static void Main(string[] args)
        {
            PreInit(new TestProgram());
            SysConsole.Init();
            Game game = new Game();
            game.Start();
        }
    }
}

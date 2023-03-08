using iOSSpeakerVsEarpiece.Services;
using Xamarin.Forms;

namespace iOSSpeakerVsEarpiece
{
    public partial class App : Application
    {

        public static IAudioPlayer AudioPlayer { get; private set; }

        public App(IAudioPlayer audio)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

            AudioPlayer = audio;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

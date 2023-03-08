using AVFoundation;
using Foundation;

namespace iOSSpeakerVsEarpiece.iOS
{
    public class iOSAudioPlayer : IAudioPlayer
    {
        public void Play()
        {
            var session = AVAudioSession.SharedInstance();
            //session.SetCategory(AVAudioSessionCategory.PlayAndRecord, AVAudioSessionCategoryOptions.DefaultToSpeaker);
            session.SetCategory(AVAudioSessionCategory.PlayAndRecord);
            session.SetActive(true);
            NSError error;
            var player = new AVAudioPlayer(new NSUrl("turd.mp3"), "mp3", out error);
            player.Volume = 1.0f;
            player.Play();
        }
    }
}
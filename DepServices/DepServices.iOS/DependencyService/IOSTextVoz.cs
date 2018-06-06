using AVFoundation;
using DepServices.DependencyServices;
using DepServices.iOS.DependencyService;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSTextVoz))]
namespace DepServices.iOS.DependencyService
{
    public class IOSTextVoz : ITextVoz
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("es-ES"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}

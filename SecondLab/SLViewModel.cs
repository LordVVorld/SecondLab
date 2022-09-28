using ReactiveUI;
using System.IO;
using System.Reactive;

namespace SecondLab
{
    public class SLViewModel : ReactiveObject
    {
        private string _XMLFileContent;
        public string XMLFileContent
        {
            get => _XMLFileContent;
            set => this.RaiseAndSetIfChanged(ref _XMLFileContent, value);
        }

        private string _deserializedText;
        public string DeserializedText
        {
            get => _deserializedText;
            set => this.RaiseAndSetIfChanged(ref _deserializedText, value);
        }

        public SLViewModel()
        {
            Start = ReactiveCommand.Create(() =>
            {
                using (var stream = new FileStream("./Resources/XMLFile.xml", FileMode.Open))
                {
                    DeserializedText = SLModel.DeserializeXML(stream).ToString();
                    stream.Position = 0;
                    XMLFileContent = SLModel.StreamFile(stream);
                }
            });
        }

        public ReactiveCommand<Unit, Unit> Start { get; private set; }
    }
}

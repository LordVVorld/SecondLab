using ReactiveUI;
using System.Reactive;

namespace SecondLab
{
    public class SLViewModel : ReactiveObject
    {
        private const string xmlFilePath = "./Resources/XMLFile.xml";

        private string _XMLFileContent = SLModel.StreamFile(xmlFilePath);
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
            DeserializeXML = ReactiveCommand.Create(() =>
            {
                DeserializedText = SLModel.DeserializeXML(xmlFilePath).ToString();
            });
        }

        public ReactiveCommand<Unit, Unit> DeserializeXML { get; private set; }
    }
}

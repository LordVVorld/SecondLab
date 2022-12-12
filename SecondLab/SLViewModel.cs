using ReactiveUI;
using System.Reactive;
using System.Windows.Forms;
using System;
using static SecondLab.SLModel;

namespace SecondLab
{
    public class SLViewModel : ReactiveObject
    {
        private readonly OpenFileDialog _fileChooser = new OpenFileDialog() { Filter = "XML Files (*.xml)|*.xml" };
        private string _path = null;

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
            ChooseFile = ReactiveCommand.Create(() =>
            {
                _path = GetFilePath(_fileChooser);
                if (!string.IsNullOrEmpty(_path))
                {
                    XMLFileContent = StreamFile(_path);
                }            
            });
            ChooseFile.ThrownExceptions.Subscribe(ex => MessageBox.Show(ex.Message, "Внимание!"));

            DeserializeXML = ReactiveCommand.Create(() =>
            {
                if (string.IsNullOrEmpty(_path))
                {
                    throw new Exception("Не выбран файл для десериализации.");
                }
                XMLFileContent = StreamFile(_path);
                DeserializedText = DeserializeXML(_path).ToString();
            });
            DeserializeXML.ThrownExceptions.Subscribe(ex => MessageBox.Show(ex.Message, "Внимание!"));
        }
        public ReactiveCommand<Unit, Unit> DeserializeXML { get; private set; }
        public ReactiveCommand<Unit, Unit> ChooseFile { get; private set; }
    }
}

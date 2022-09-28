using ReactiveUI;
using System.Windows.Forms;

namespace SecondLab
{

    public partial class SLView : Form, IViewFor<SLViewModel>
    {
        public SLView()
        {
            InitializeComponent();


            this.WhenActivated(a =>
            {
                a(this.OneWayBind(ViewModel, vm => vm.DeserializedText, v => v.deserializedTextBox.Text));
                a(this.OneWayBind(ViewModel, vm => vm.XMLFileContent, v => v.XMLFileTextBox.Text));
                a(this.BindCommand(ViewModel, vm => vm.Start, v => v.startButton));
            });
            ViewModel = new SLViewModel();
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (SLViewModel)value;
        }

        public SLViewModel ViewModel { get; set; }
    }
}

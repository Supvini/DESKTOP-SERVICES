using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows.Data;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Data;
using Telerik.Windows.Controls.Input;

namespace DESKTOP_SERVICES.Controls
{
    /// <summary>
    /// Logique d'interaction pour DossierTechnique.xaml
    /// </summary>
    public partial class DossierTechnique : UserControl
    {
        public DossierTechnique()
        {
            InitializeComponent();
            ShowInfo();
        }


        private void ShowInfo()
        {
            RadDataForm InfoGen = new RadDataForm()
            {
                Header = "Informations générales:",
                Height = 150,
                Width = 300

            };

            this.dossierTechniqueStack.Children.Add(InfoGen);
        }
    }
}

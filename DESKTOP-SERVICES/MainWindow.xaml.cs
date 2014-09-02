using DESKTOP_SERVICES.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Navigation;
using Telerik.Windows.Data;

namespace DESKTOP_SERVICES
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region GestionTab

        String clickValue = "";
        private void DTechnique_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "DTechnique_Click";
            addOnglet();


        }

        private void LAffections_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "LAffections_Click";
            addOnglet();
        }

        private void LInformationsLies_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "LInformationsLies_Click";
            addOnglet();
        }

        private void LContactsClients_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "LContactsClients_Click";
            addOnglet();
        }

        private void SContratsEngagements_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "SContratsEngagements_Click";
            addOnglet();
        }

        private void LProfilsUtilisateurs_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "LProfilsUtilisateurs_Click";
            addOnglet();
        }

        private void PServicesReu_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "PServicesReu_Click";
            addOnglet();
        }

        private void PServicesMay_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "PServicesMay_Click";
            addOnglet();
        }

        private void FOuverture_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "FOuverture_Click";
            addOnglet();
        }

        private void SIncidents_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "SIncidents_Click";
            addOnglet();
        }

        private void FOuvertureSAV_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "FOuvertureSAV_Click";
            addOnglet();
        }

        private void SuiviSAV_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "SuiviSAV_Click";
            addOnglet();
        }

        private void PlanningPrevision_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "PlanningPrevision_Click";
            addOnglet();
        }

        private void FichesTemps_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "FichesTemps_Click";
            addOnglet();
        }

        private void AlertMails_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "AlertMails_Click";
            addOnglet();
        }

        private void MonSuiviIncident_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "MonSuiviIncident_Click";
            addOnglet();
        }

        private void IndexCategories_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "IndexCategories_Click";
            addOnglet();
        }

        private void AjouterArticle_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "AjouterArticle_Click";
            addOnglet();
        }

        private void MesArticles_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            clickValue = "MesArticles_Click";
            addOnglet();
        }

        private void addOnglet()
        {
            switch (clickValue)
            {
                #region caseClickValue

                case "DTechnique_Click":

                    RadTabItem DossierTechniqueTab = new RadTabItem() { Header = "Dossier technique", IsSelected = true };
                    radTabControl.Items.Add(DossierTechniqueTab);

                    DossierTechnique dt = new DossierTechnique();
                    DossierTechniqueTab.Content = dt;


                    break;

                case "LAffections_Click":
                    RadTabItem ListeAffectationsTab = new RadTabItem() { Header = "Liste des affectations", IsSelected = true };
                    radTabControl.Items.Add(ListeAffectationsTab);

                    ListeAffectations listeAffectation = new ListeAffectations();
                    ListeAffectationsTab.Content = listeAffectation;

                    break;

                case "LInformationsLies_Click":
                    RadTabItem ListeInformationsLiesTab = new RadTabItem() { Header = "Liste des informations liées", IsSelected = true };
                    radTabControl.Items.Add(ListeInformationsLiesTab);
                    break;

                case "LContactsClients_Click":
                    RadTabItem ListeContactsClientsTab = new RadTabItem() { Header = "Liste des contacts clients", IsSelected = true };
                    radTabControl.Items.Add(ListeContactsClientsTab);
                    break;

                case "SContratsEngagements_Click":
                    RadTabItem SuiviContratsEngagementTab = new RadTabItem() { Header = "Suivi des contrats et des engagements liés", IsSelected = true };
                    radTabControl.Items.Add(SuiviContratsEngagementTab);
                    break;

                case "LProfilsUtilisateurs_Click":
                    RadTabItem ListeProfilsUtilisateursTab = new RadTabItem() { Header = "Liste et profil des utilisateurs", IsSelected = true };
                    radTabControl.Items.Add(ListeProfilsUtilisateursTab);
                    break;

                case "PServicesReu_Click":
                    RadTabItem PlanningServicesReuTab = new RadTabItem() { Header = "Planning Services (Réunion)", IsSelected = true };
                    radTabControl.Items.Add(PlanningServicesReuTab);
                    break;

                case "PServicesMay_Click":
                    RadTabItem PlanningServicesMayTab = new RadTabItem() { Header = "Planning Services (Mayotte)", IsSelected = true };
                    radTabControl.Items.Add(PlanningServicesMayTab);
                    break;

                case "FOuverture_Click":
                    RadTabItem FicheOuvertureTab = new RadTabItem() { Header = "Fiche d'ouverture", IsSelected = true };
                    radTabControl.Items.Add(FicheOuvertureTab);
                    break;

                case "SIncidents_Click":
                    RadTabItem SuiviIncidentsTab = new RadTabItem() { Header = "Suivi des incidents", IsSelected = true };
                    radTabControl.Items.Add(SuiviIncidentsTab);
                    break;

                case "FOuvertureSAV_Click":
                    RadTabItem FicheOuvertureSAVTab = new RadTabItem() { Header = "Fiche d'ouverture SAV", IsSelected = true };
                    radTabControl.Items.Add(FicheOuvertureSAVTab);
                    break;

                case "SuiviSAV_Click":
                    RadTabItem SuiviSAVTab = new RadTabItem() { Header = "Suivi SAV", IsSelected = true };
                    radTabControl.Items.Add(SuiviSAVTab);
                    break;

                case "PlanningPrevision_Click":
                    RadTabItem PlanningPreviosionneltab = new RadTabItem() { Header = "Mon planning prévisionnel", IsSelected = true };
                    radTabControl.Items.Add(PlanningPreviosionneltab);
                    break;

                case "FichesTemps_Click":
                    RadTabItem MesFichesTempsTab = new RadTabItem() { Header = "Mes fiches de temps", IsSelected = true };
                    radTabControl.Items.Add(MesFichesTempsTab);
                    break;

                case "AlertMails_Click":
                    RadTabItem MesAlertesMailTab = new RadTabItem() { Header = "Mes alertes mails", IsSelected = true };
                    radTabControl.Items.Add(MesAlertesMailTab);
                    break;

                case "MonSuiviIncident_Click":
                    RadTabItem MonSuiviIncidentTab = new RadTabItem() { Header = "Mon suivi d'incidents", IsSelected = true };
                    radTabControl.Items.Add(MonSuiviIncidentTab);
                    break;

                case "IndexCategories_Click":
                    RadTabItem IndexCategoriesTab = new RadTabItem() { Header = "Wiki - Index des catégories", IsSelected = true };
                    radTabControl.Items.Add(IndexCategoriesTab);
                    break;

                case "AjouterArticle_Click":
                    RadTabItem AjouterArticleTab = new RadTabItem() { Header = "Wiki - Ajouter des articles", IsSelected = true };
                    radTabControl.Items.Add(AjouterArticleTab);
                    break;

                case "MesArticles_Click":
                    RadTabItem MesArticlesTab = new RadTabItem() { Header = "Wiki - Mes articles", IsSelected = true };
                    radTabControl.Items.Add(MesArticlesTab);
                    break;
                #endregion
            }

        }

        #endregion
    }
}

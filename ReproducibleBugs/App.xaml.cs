using ReproducibleBugs.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace ReproducibleBugs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
            //Don't fill and expand in first load when this boxview is wrapped inside the navigationpage
            //new Window(new NavigationPage(new GridBugPage()))
            //But if you remove the NavigationPage it works good
            => new Window(new NavigationPage(new GridBugPage()));
    }
}
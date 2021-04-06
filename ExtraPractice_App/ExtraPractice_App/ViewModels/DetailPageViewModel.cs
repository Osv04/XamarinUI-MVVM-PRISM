using ExtraPractice_App.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtraPractice_App.ViewModels
{
    public class DetailPageViewModel : BaseViewModel, IInitialize
    {
        public Music SelectedMusic { get; set; } = new Music();
        public DelegateCommand GoBackCommand { get; set; }
        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.ContainsKey("Music"))
            {
                SelectedMusic = parameters["Music"] as Music;
            }
        }

        public DetailPageViewModel(INavigationService navigation) : base(navigation)
        {
            GoBackCommand = new DelegateCommand(async () =>
            {
                await NavigationService.GoBackAsync();

            });

        }
    }
}


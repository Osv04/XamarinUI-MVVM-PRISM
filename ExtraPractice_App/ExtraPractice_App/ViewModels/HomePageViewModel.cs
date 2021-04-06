using ExtraPractice_App.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ExtraPractice_App.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public DelegateCommand<Music> GoToDetailPage { get; set; }
        public ObservableCollection<Music> Musics { get; set; } = new ObservableCollection<Music>();

        public HomePageViewModel(INavigationService navigation) : base(navigation)
        {
            Musics.Add(new Music { Name = "Raining Sidewalk", Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", Lenght="5 mins", Photo="rainingSidewalk.jpg", Title="Article Title"});
            Musics.Add(new Music { Name = "Spring Morning", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", Lenght = "7 mins", Photo = "springMorning.jpg", Title = "Article Title" });
            Musics.Add(new Music { Name = "First Snow", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", Lenght = "30 mins", Photo = "firstSnow.jpg", Title = "Article Title" });

            GoToDetailPage = new DelegateCommand<Music>(async (param) =>
            {
                var nav = new NavigationParameters();
                nav.Add("Music", param);

                await NavigationService.NavigateAsync("/DetailPage", nav);

            });
        }

    }
}

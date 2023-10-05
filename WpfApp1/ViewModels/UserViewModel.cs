using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        
        private readonly UserService userService;
        private readonly RelayCommand readCommand;
        private readonly RelayCommand createCommand;
        private readonly RelayCommand updateCommand;
        private readonly RelayCommand deleteCommand;
        private readonly RelayCommand newCommand;

        public RelayCommand ReadCommand => readCommand;
        public RelayCommand CreateCommand => createCommand;
        public RelayCommand UpdateCommand => updateCommand;
        public RelayCommand DeleteCommand => deleteCommand;
        public RelayCommand NewCommand => newCommand;


        private ObservableCollection<User> users = new();
        private User currentUser = new();

        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
        public User CurrentUser
        {
            get => currentUser;
            set
            {
                currentUser = value;
                OnPropertyChanged(nameof(CurrentUser));
            }
        }



        public UserViewModel()
        {
            userService = new();
            Search();
            readCommand = new RelayCommand(Search);
            createCommand = new RelayCommand(Create);
            updateCommand = new RelayCommand(Update);
            deleteCommand = new RelayCommand(Delete);
            newCommand = new RelayCommand(New);
        }

        private void Search()
        {
            Users = new ObservableCollection<User>(userService.GetAllUsers());
        }

        private void Create()
        {
            userService.CreateUser(currentUser);
            Search();
        }

        private void Update()
        {
            userService.UpdateUser(currentUser);
        }

        private void Delete()
        {
            userService.DeleteUser(currentUser);
            Search();
        }

        private void New()
        {
            CurrentUser = new()
            {
                ID = int.MinValue
            };
        }
    }
}

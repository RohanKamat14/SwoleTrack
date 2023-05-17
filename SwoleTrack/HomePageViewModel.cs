

//using CommunityToolkit.Mvvm.ComponentModel;
//using Microsoft.Toolkit.Mvvm.Input;
//using System.Collections.ObjectModel;

//namespace SwoleTrack.ViewModel
////{
////    public partial class HomePageViewModel : ObservableObject
////    {

////        public HomePageViewModel()
////        {

////        }
////        [ObservableProperty]
////        ObservableCollection<string> items;
////        [ObservableProperty]
////        string text;

////        [ICommand]
////        void Add(string text)
////        {
////            object[] obj = { "this", "that", "those" };
////            Random rn = new Random();
////            object ob = rn.Next(0, obj.Length);
////        }

////    }
////}














//    {
//        public event ProgressChangedEventHandler PropertyChanged;

//        string text;
//        public string Text
//        {
//            get => Text;
//            set
//            {
//                Text = value;
//                OnPropertyChanged();
//            }
//        }
//        public void OnPropertyChanged(string name) =>
//            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//    }
//}


//public global::System.String Text { get => text; set => text = value; }
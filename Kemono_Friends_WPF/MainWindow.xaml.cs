using System.Windows;
using System.Windows.Input;

namespace Kemono_Friends_WPF
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public string Specialty;
		public string[] FriendsGoroku = new string[] { "わーい", "すごーい", "うわー！" };

		private void KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				Specialty = specialtyTextbox.Text;

				System.Random r = new System.Random();
				string Word = FriendsGoroku[r.Next(4)] + "\n" + "君は" + Specialty + "が得意なフレンズなんだね！";
				Hukidashi.Text = Word;
			}
		}
	}
}

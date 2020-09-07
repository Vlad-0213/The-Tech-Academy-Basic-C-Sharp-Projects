using System;


namespace myConsoleProject.cs
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			Console.WriteLine("what is your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, " + name + "!");
			Console.Read();
			InitializeComponent();
		}
	}
}


using System.Windows.Forms;

public static class root
{
	public static string myvar = "778";

	public static class aaabbb
	{
		public static string str = "gggtext";

		public static void showmessage(string text)
		{
			MessageBox.Show(text);
		}
	}
}

public static class root2
{
	public static string myvar2 = "445"; 
}

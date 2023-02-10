using System.Security.Cryptography.X509Certificates;
using Contact_Application.Components;
using Contact_Application.Utilities;
using Contact_Application.Pages;


namespace Contact_ApplicationTest
{
	public class UnitTest1
	{
		ContactBook contactBook = new ContactBook();

		public List<Contact> Contacts = new List<Contact>()
		{
			new Contact("Kalle", "Persson", "kalle.persson@exempel.com", 0701231122),
			new Contact("Anders", "Andersson", "anders.andersson@exempel.com", 0701231122),
			new Contact("Stina", "Svensson", "stina.Svensson@exempel.com", 0701231122),
			new Contact("Kaj", "Bergström", "kaj.bergström@exempel.com", 0701231122),
			new Contact("Maja", "Johansson", "Maja.Johansson@exempel.com", 0701231122),
		};

		[Theory]
		[InlineData(0, "Anders")]
		[InlineData(4, "Stina")]

		public void TestIfListIsSorted(int index, string name)
		{

			var sorted = contactBook.SortContacts(Contacts);

			Assert.Equal(sorted[index].Name, name);
		}

	}
}

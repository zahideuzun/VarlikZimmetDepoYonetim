using System;
using System.Linq;


namespace VarlikZimmetDepoYonetim.Provider
{
	public class ExtensionMethod
	{
		/// <summary>
		/// girilen bilgilerin hicbiri bos olmamalidir. bos deger yoksa true döner.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool NullValidator(string a, string b)
		{
			return ((!string.IsNullOrWhiteSpace(a))
					&& (!string.IsNullOrWhiteSpace(b)));
		}

		/// <summary>
		/// girilen bilgilerin hicbiri bos olmamalidir. bos deger yoksa true döner.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <returns></returns>
		public bool NullValidator(string a, string b, string c)
		{
			return ((!string.IsNullOrWhiteSpace(a))
					&& (!string.IsNullOrWhiteSpace(b)
						&& (!string.IsNullOrWhiteSpace(c))));
		}
		/// <summary>
		/// girilen bilgilerin hicbiri bos olmamalidir. bos deger yoksa true döner.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		/// <param name="d"></param>
		/// <returns></returns>
		public bool NullValidator(string a, string b, string c, string d)
		{
			return ((!string.IsNullOrWhiteSpace(a))
					&& (!string.IsNullOrWhiteSpace(b)
						&& (!string.IsNullOrWhiteSpace(d))
						&& (!string.IsNullOrWhiteSpace(c))));
		}

		/// <summary>
		/// mail bos gecilmemeli. icerisinde @ olmali ve sonu .com ile bitmelidir.
		/// </summary>
		/// <param name="mail"></param>
		/// <returns></returns>
		public bool MailValidator(string mail)
		{
			return (!string.IsNullOrWhiteSpace(mail)
					&& mail.Contains('@')
					&& mail.EndsWith(".com"));
		}

		/// <summary>
		/// isim soyisimde yalnızca harfler olmalıdır. // Ad en az iki kelimeden oluştuğu için boşluk içermek zorunda ama bu boşluklar başta ve sonda olamaz.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public bool NameValidator(string name)
		{
			if (name.Contains(" ")
				&& !name.EndsWith(" ")
				&& !name.StartsWith(" "))
			{
				for (int i = 0; i < name.Length; i++)
				{
					if (!(Char.IsLetter(name[i]) || name[i] == ' ')) // 1 harf bile varsa ya da bosluk, iceri girdigi icin true dönüyo o yuzden degilini alip false demem gerek!
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}
}

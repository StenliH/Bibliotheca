using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheca
{
	public static class Authentication
	{
		public static bool VerifyPassword(string currentPassword, string passToVerify)
		{
			return currentPassword == passToVerify;
		}
	}
}

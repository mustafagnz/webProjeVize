using System;
namespace webProjeVize.Models
{
	public class authentication
	{
        public string errosMessage { get; set; }
		public bool UsernamePasswordController(string username, string password)
		{
            if (username == "mustafa@gmail.com" && password == "1234")
            {
                
                return true;

            }
            else
            {
                errosMessage = "kullanıcı adı bulunamadı";
                return false;
            }

        }
	}
}


namespace Katas.NetCore.PasswordChecker
{
    public class PasswordChecker
    {

        public string Check(string password)
        {
            if (password == string.Empty)
            {
                return "Password is blank";
            }

            if (password.Length < 8)
            {
                return "Length is less than 8";
            }

            if(password.ToLower() == password)
            {
                return "Password doesn't have any uppercase letters";
            }

            if(password.Replace(" ", "") == password)
            {
                return "Password doesn't have any spaces";
            }

            return "Password is acceptable";
        }
    }
}

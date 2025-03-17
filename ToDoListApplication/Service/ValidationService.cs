namespace ToDoListApplication.Service
{
    public class ValidationService
    {
        public bool IsValidInput(string input, string allowedSpecialCharaceter = "")
        {
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }
            var validCharacters = allowedSpecialCharaceter.ToHashSet();

            return input.All(c => char.IsLetterOrDigit(c) || validCharacters.Contains(c));
        }

        public bool XXSProtection(string input)
        {
            return input.Contains("<script>");
        }
    }
}

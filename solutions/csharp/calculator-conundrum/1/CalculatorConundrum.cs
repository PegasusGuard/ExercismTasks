public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        string result = $"{operand1} {operation} {operand2} =";
        switch (operation)
        {
            case "+":
                return $"{result} {operand1 + operand2}";
            case "*":
                return $"{result} {operand1 * operand2}";
            case "/":
                if (operand2 == 0)
                    return "Division by zero is not allowed.";
                return $"{result} {operand1 / operand2}";
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

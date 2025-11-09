namespace task2;

public class Calculator
{
    public static float Calculate(int num1, int num2, char operation)
    {
        float result = 0;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = (float) num1 / num2;
                }
                else {
                    throw new DivideByZeroException("You can't divide by zero!");
                }
                break;
            default:
                throw new ArgumentException("Invalid operation!");
        }

        return result;
    }
}
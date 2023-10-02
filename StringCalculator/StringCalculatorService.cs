using System.Collections;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public int Add(string numbers) 
        {
            char[] separador = {'\n',  ','};
            int suma = 0;
            
            if (String.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            
            if (numbers.StartsWith("//"))
            {
                char [] arrayNumbers = numbers.ToCharArray();
                char[] limitadores = { arrayNumbers[2], '\n', '/' };

                var parts2 = numbers.Split(limitadores, StringSplitOptions.RemoveEmptyEntries);

                List<int> list = new List<int>();
                for (int i = 0; i < parts2.Length; i++)
                {
                    if (int.Parse(parts2[i]) < 0)
                    {
                        list.Add(int.Parse(parts2[i]));
                    }
                    else
                    {
                        suma = suma + int.Parse(parts2[i]);
                    }
                }
                if (list != null)
                {
                    Console.WriteLine("Los numeros negativos no son permitidos: "+ list);
                }

                return suma;
            }
            
            var parts=numbers.Split(separador, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                suma = suma + int.Parse(parts[i]);
            }

            return suma;
        }
    }
}
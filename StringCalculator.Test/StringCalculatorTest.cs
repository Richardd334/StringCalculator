namespace StringCalculator.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
         public void RetornaCeroSiReciveCadenaVacia()
        {
            //Arrange
            StringCalculatorService service= new StringCalculatorService();

            //Act
            int resultado = service.Add("");

            //Assert
           Assert.AreEqual(0, resultado);
        }


        [TestMethod]

        [DataRow("5", 5)]
        [DataRow("10000", 10000)]
        [DataRow("89234", 89234)]
        [DataRow("8998", 8998)]
        public void RetornaCeroSiReciveNumero(String number, int ResultadoCorrecto)
        {
            //Arrange
            StringCalculatorService service = new StringCalculatorService();

            //Act
            int resultado = service.Add(number);

            //Assert
            Assert.AreEqual(ResultadoCorrecto, resultado);
        }


        [TestMethod]
        public void RetornaCeroSiReciveDosNumeros()
        {
            //Arrange
            StringCalculatorService service = new StringCalculatorService();

            //Act
            int resultado = service.Add("5,10");

            //Assert
            Assert.AreEqual(15, resultado);
        }

        [TestMethod]
        [DataRow("5,5,3", 13)]
        [DataRow("5,5\n3,1\n2", 16)]
        [DataRow("1,1,1,1,1", 5)]
        [DataRow("5,10,10,5", 30)]
        [DataRow("//;\n5;10;10;5", 30)]
        [DataRow("//%\n5%10%10%5", 30)]
        [DataRow("//;\n5;10;10;5;-10;-4", 30)]



        public void RetornaCeroSiReciveMuchosNumeros(string numeros, int resultadoCorrecto )
        {
            //Arrange
            StringCalculatorService service = new StringCalculatorService();

            //Act
            int resultado = service.Add(numeros);

            //Assert
            Assert.AreEqual(resultadoCorrecto, resultado);
        }
    }
}
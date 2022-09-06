using Moq;

namespace Programa.Testen
{
    public class ProgrammaTests
    {
        [Fact]
        public void Add_AddsNumbers()
        {
            int input1 = 5;
            int input2 = 6;
            int expected = 11;
            Programma sut = new Programma();
            int actual = sut.Add(input1, input2);
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Begroeting()
        {
            Programma sut = new Programma();
            Mock<Begroetingsgenerator> generator = new Mock<Begroetingsgenerator>("Hoi");
            generator.Setup((a) => a.Genereer()).Returns("Hallo");
            var expected = "Hallo Pietje";
            var actual = sut.Begroeting(generator.Object, "Pietje");
            Assert.Equal(expected, actual);
        }
    }

}
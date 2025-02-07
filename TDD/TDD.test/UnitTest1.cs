using TDD;

namespace TDD.test
{
    public class Tests
    {

        RechercheVille? _rechercheVille;

        [SetUp]
        public void Setup()
        {
            _rechercheVille = new RechercheVille();
        }

        [Test]
        public void ExceptionIfLessThan2Char()
        {
            var exception = Assert.Throws<NotFouond>(() => target.MethodThatThrows(null));
            Assert.That(exception.ParamName, Is.EqualTo("parameterName"));
        }
    }
}
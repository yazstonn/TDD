using TDD;

namespace TDD.test
{
    [TestFixture]
    public class Tests
    {

        RechercheVille? _rechercheVille;

        [SetUp]
        public void Setup()
        {
            _rechercheVille = new RechercheVille();
        }

        [Test]
        [TestCase("a")]
        [TestCase("a")]
        [TestCase("")]
        [TestCase("g")]
        [TestCase("z")]
        [TestCase("t")]
        [TestCase("x")]
        [TestCase("k")]
        public void ExceptionIfLessThan2Char(string a)
        {
           var exception = Assert.Throws<NotFoundException>(() => _rechercheVille.Rechercher(a));
        }
    }
}
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
           Assert.Throws<NotFoundException>(() => _rechercheVille.Rechercher(a));
        }


        [TestCase("Va", new string[] { "Valence" , "Vancouver" })]
        [TestCase("Pa", new string[] { "Paris" })]
        [TestCase("Vale", new string[] { "Valence" })]
        [TestCase("Is", new string[] { "Istanbul", "Islamabad" })]
        public void GetVilleWithPrefix(string a,string[] b) 
        {
            CollectionAssert.IsSubsetOf(b, _rechercheVille.Rechercher(a));
        }
    }
}
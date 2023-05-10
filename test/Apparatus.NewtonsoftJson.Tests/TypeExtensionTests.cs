using Apparatus;
using Xunit;

namespace ApparatusTests
{

    public class TypeExtensionTests
    {
        public class Example
        {
            public string A { get; set; }
        }

        [Fact]
        public void TypeObjectLoadedFromJson()
        {
            var obj = typeof(Example).ObjectFromJson("{'A': 'abc'}");


            Assert.IsType<Example>(obj);
        }
    }
}

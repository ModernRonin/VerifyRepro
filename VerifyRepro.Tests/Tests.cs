using System.Threading.Tasks;
using NUnit.Framework;
using VerifyNUnit;

namespace VerifyRepro.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public Task Test1()
    {
        return Verifier.Verify("bla");
    }
}
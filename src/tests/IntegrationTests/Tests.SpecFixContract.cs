namespace Nixtla.IntegrationTests;

/// <summary>
/// What generate.sh does to the spec, checked without an API key.
///
/// The upstream spec declares no top-level `security`, so generate.sh injects one with jq. Without it
/// no operation is authenticated at all and every call comes back 401 - at runtime, not at build time.
///
/// Every other test here needs a key and reports inconclusive without one, so the suite printed
/// `Skipped!` and exited 0 - which looks exactly like a passing run. These two do not touch the
/// network.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheClientSendsTheCredentialTheSpecFixAsksFor()
    {
        using var client = new global::Nixtla.NixtlaClient("test-key");

        var authorization = client.Authorizations.SingleOrDefault(
            x => x.Type == "Http" && x.Location == "Header");

        Assert.IsNotNull(
            authorization,
            $"Expected one Http credential in the Header, found: " +
            string.Join(", ", client.Authorizations.Select(x => $"{x.Type}/{x.Location}/{x.Name}")) +
            ". This comes from the --security-scheme in generate.sh; if a spec refresh changed it, " +
            "fix the flag rather than the test.");
        Assert.AreEqual("Bearer", authorization.Name);
        Assert.AreEqual("test-key", authorization.Value);
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://api.nixtla.io/", global::Nixtla.NixtlaClient.DefaultBaseUrl);
    }
}

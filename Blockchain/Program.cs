using NBitcoin;

namespace Blockchain;

internal class Program
{
    static void Main(string[] args)
    {
        Key privateKey = new Key();
        PubKey publicKey = privateKey.PubKey;
        Console.WriteLine(publicKey);
    }
}

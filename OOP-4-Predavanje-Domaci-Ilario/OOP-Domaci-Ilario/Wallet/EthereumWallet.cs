using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;

public sealed class EthereumWallet : Wallet
{
    public List<Guid> AddressesOfOwnedNonFungibleAssets { get; set; }

    public EthereumWallet()
    {
        AddressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public override void PrintWallet(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        Console.WriteLine($"\n Type: Etherum \t Address: {base.Address} \n");
        var totalValueOfAssets = ReturnTotalValueOfFungibleAssets(assets);
        Console.WriteLine(totalValueOfAssets is 0m
            ? "Total value of all assets: 0$ \n"
            : $"Total value of all assets: {totalValueOfAssets}\n");
        if (assets.Count is 0)
        {
            Console.WriteLine("Wallet dose not have any assets\n");
        }
        else
        {
            Console.WriteLine("Assets that the wallet has: \n");
            foreach (var item in FungibleAssetsBalance)
            {
                Console.WriteLine(assets.Find(x => x.Address.Equals(item.Address)).Name);
            }
            foreach (var item in AddressesOfOwnedNonFungibleAssets)
            {
                Console.WriteLine(assets.Find(x => x.Address.Equals(item)).Name);
            }
        }
        Console.WriteLine("Implement later\n");
    }

    public decimal ReturnTotalValueOfFungibleAssets(List<Asset> assets)
    {
        return 0m;
    }

    public decimal ReturnTotalValueOfNonFungibleAssets(List<Asset> assets)
    {
        return 0m;
    }
    
}
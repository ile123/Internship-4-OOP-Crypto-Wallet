using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Wallet;

using Asset;
using Transaction;

public sealed class EthereumWallet : Wallet, IFungibleWallet, INonFungibleWallet
{
    public List<Guid> AddressesOfOwnedNonFungibleAssets { get; set; }

    public EthereumWallet()
    {
        AddressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public override void PrintWallet(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        Console.WriteLine($"\nType: Etherum \t Address: {Address} \n");
        var totalValueOfAssets = ReturnTotalValueOfAssets(assets);
        
        Console.WriteLine(totalValueOfAssets is 0m
            ? "Total value of all assets: 0$ \n"
            : $"Total value of all assets: {totalValueOfAssets} $\n");
        Console.WriteLine(ReturnPercentageChangeInAllAssets(assets,fungibleAssetTransactions));
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
    }

    public void AddFungibleAssetToList(FungibleAsset asset, int amount)
    {
        FungibleAssetsBalance.Add((asset.Address, amount));
    }

    public void AddNonFungibleAssetToList(NonFungibleAsset asset)
    {
        AddressesOfOwnedNonFungibleAssets.Add(asset.Address);
    }

    public decimal ReturnTotalValueOfAssets(List<Asset> assets)
    {
        var total = (from item in FungibleAssetsBalance let asset = assets.Find(x => x.Address.Equals(item.Address)) select item.Balance * asset.Value).Sum();

        foreach (var asset in AddressesOfOwnedNonFungibleAssets.Select(item => assets.Find(x => x.Address.Equals(item))))
        {
            if (asset is INonFungible nonFungible)
            {
                total += nonFungible.ReturnValue(assets);
            }
        }
        return total;
    }
    
    private string ReturnPercentageChangeInAllAssets(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        var percentage = 0m;
        var previousValuesFungible = 0m;
        var previousValuesNonFungible = 0m;
        var currentValues = ReturnTotalValueOfAssets(assets);
        if (fungibleAssetTransactions.Find(x => x.Sender.Equals(Address)) is null)
        {
            return "This wallet has not made any transactions!\n";
        }

        if (FungibleAssetsBalance.Count is not 0)
        {
            previousValuesFungible = (from item in FungibleAssetsBalance 
                select fungibleAssetTransactions.Where(x => x.Asset.Equals(item.Address)) 
                into allAssetsTransactions select allAssetsTransactions.OrderBy(x => x.TransactionDate).Last() 
                into asset select asset.AssetValue).Sum();
        }

        if (AddressesOfOwnedNonFungibleAssets.Count is not 0)
        {
            previousValuesNonFungible = (from item in AddressesOfOwnedNonFungibleAssets 
                let nonFungibleAssetTransaction = fungibleAssetTransactions.Where(x => x.Asset.Equals(item)) 
                let nonFungibleAsset = nonFungibleAssetTransaction.OrderBy(x => x.TransactionDate).Last() 
                select nonFungibleAsset.AssetValue * assets.Find(x => x.Address.Equals(item)).Value).Sum();
        }
        var previousValues = previousValuesFungible + previousValuesNonFungible;

        if (previousValues > currentValues)
        {
            percentage = (previousValues % currentValues) * 100;
            return $"Total value of the wallet has dropped by {percentage}!\n";
        }
        percentage = (currentValues % previousValues) * 100;
        return $"Total value of the wallet has increased by {percentage}!\n";
    }
    
}
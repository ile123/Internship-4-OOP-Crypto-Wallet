using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Wallet;

using Asset;
using Transaction;

public sealed class BitcoinWallet : Wallet, IFungibleWallet
{
    public decimal ReturnTotalValueOfFungibleAssets(List<Asset> assets)
    {
        if (assets.Count is 0)
        {
            return 0m;
        }

        return (from item in FungibleAssetsBalance let assetValue = assets.Find(x => x.Address.Equals(item.Address)).Value where assetValue is not 0m select assetValue * item.Balance).Sum();
    }

    private string ReturnPercentageChangeInAllAssets(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        var percentage = 0m;
        var currentValues = ReturnTotalValueOfFungibleAssets(assets);
        if (fungibleAssetTransactions.Find(x => x.Sender.Equals(Address)) is null)
        {
            return "This wallet has not made any transactions!\n";
        }
        if(FungibleAssetsBalance.Count is 0)
        {
            return "This wallet dose not contain any assets!\n";
        }

        var previousValues = (from item in FungibleAssetsBalance 
            select fungibleAssetTransactions.Where(x => x.Asset.Equals(item.Address)) 
            into allAssetsTransactions select allAssetsTransactions.OrderBy(x => x.TransactionDate).Last() 
            into asset select asset.AssetValue).Sum();

        if (previousValues > currentValues)
        {
            percentage = (previousValues % currentValues) * 100;
            return $"Total value of the wallet has dropped by {percentage}!\n";
        }
        percentage = (currentValues % previousValues) * 100;
        return $"Total value of the wallet has increased by {percentage}!\n";
    }

    public override void PrintWallet(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        Console.WriteLine($"\nType: Bitcoin \t Address: {Address} \n");
        var totalValueOfAssets = ReturnTotalValueOfFungibleAssets(assets);
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
        }
    }

    public void AddFungibleAssetToList(FungibleAsset asset, int amount)
    {
        FungibleAssetsBalance.Add((asset.Address, amount));
    }
    
}
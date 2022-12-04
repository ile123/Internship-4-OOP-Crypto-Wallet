using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;

public sealed class BitcoinWallet : Wallet
{
    public decimal ReturnTotalValueOfFungibleAssets(List<Asset> assets)
    {
        var total = Decimal.Zero;
        if (assets.Count is 0)
        {
            return 0m;
        }
        foreach (var item in base.FungibleAssetsBalance)
        {
            var assetValue = assets.Find(x => x.Address.Equals(item.Address)).Value;
            if (assetValue is not 0m)
            {
                total += assetValue * item.Balance;
            }
        }
        return total;
    }

    private static int ReturnPercentageChangeInAllAssets(List<(Guid address, DateTime date, decimal value)> fungibleAssetPriceHistory)
    {
        return 0;
    }

    public override void PrintWallet(List<Asset> assets, List<Transaction> fungibleAssetTransactions)
    {
        Console.WriteLine($"\n Type: Bitcoin \t Address: {base.Address} \n");
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
        }
        Console.WriteLine("Implement later\n");
        //dodaj kasnijek kada skuzis kako
        /*
        else
        {
            foreach (var item in assets)
            {
                var lastRecord = assets.Where(x => x.Address.Equals(item.Address)).ToList().OrderBy(x => x.Value)
                    .Last();
                var firstNumber = Decimal.ToInt32(lastRecord.Value);
                var secondNumber = Decimal.ToInt32(item.Value);
                if (firstNumber > secondNumber)
                {
                    percentage = firstNumber - secondNumber;
                    percentage %= firstNumber * 100;
                    Console.WriteLine("Vale");
                }
            }
        }
        */
    }
}
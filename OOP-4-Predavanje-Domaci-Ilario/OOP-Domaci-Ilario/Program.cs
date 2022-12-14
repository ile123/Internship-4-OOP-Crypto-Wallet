
using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Interfaces;
using OOP_Domaci_Ilario.Transaction;
using OOP_Domaci_Ilario.Wallet;

var wallets = new List<Wallet>()
{
    new BitcoinWallet(),
    new BitcoinWallet(),
    new BitcoinWallet(),
    new EthereumWallet(),
    new EthereumWallet(),
    new EthereumWallet(),
    new SolanaWallet(),
    new SolanaWallet(),
    new SolanaWallet()
};

var assets = new List<Asset>()
{
    new FungibleAsset("Bitcoin", 16874.93m,"BTC"),
    new FungibleAsset("Ethereum", 1275.98m,"ETH"),
    new FungibleAsset("Tether", 0.9999m,"USDT"),
    new FungibleAsset("BNB", 297.51m,"BNB"),
    new FungibleAsset("USD Coin", 1.00m,"USDC"),
    new FungibleAsset("Binance USD", 1.00m,"BUSD"),
    new FungibleAsset("XRP", 0.4m,"XRP"),
    new FungibleAsset("Dogecoin", 0.1026m,"DOGE"),
    new FungibleAsset("Cardano", 0.3135m,"ADA"),
    new FungibleAsset("Polygon", 0.8834m,"MATIC"),
};

var transactions = new List<Transaction>();

void AppendNonFungibleAssets()
{
    var assetAddress = assets[1].Address;
    var nonFungibleAssets = new List<Asset>()
    {
        new NonFungibleAsset("KILLABEARS", 2.99m, assetAddress),
        new NonFungibleAsset("1337 skulls", 0.23m, assetAddress),
        new NonFungibleAsset("The Memes", 0.25m, assetAddress),
        new NonFungibleAsset("Mutant Ape Yacht Club", 13.07m, assetAddress),
        new NonFungibleAsset("Bored Ape Yacht Club", 68.97m, assetAddress),
        new NonFungibleAsset("DEGEN TOONZ COLLECTION", 0.72m, assetAddress),
        new NonFungibleAsset("CLONE X", 8.60m, assetAddress),
        new NonFungibleAsset("ENS", 0.01m, assetAddress),
        new NonFungibleAsset("RarePass", 35m, assetAddress),
        new NonFungibleAsset("Pre-Process", 7.50m, assetAddress),
        new NonFungibleAsset("Otherdeed for Otherside", 1.32m, assetAddress),
        new NonFungibleAsset("Abstraction", 0.40m, assetAddress),
        new NonFungibleAsset("LuppyClubOfficial", 1m, assetAddress),
        new NonFungibleAsset("Valhalla", 0.77m, assetAddress),
        new NonFungibleAsset("The Sandbox", 1.09m, assetAddress),
        new NonFungibleAsset("Pudgy Penguins", 3.33m, assetAddress),
        new NonFungibleAsset("Dabloons Adventure", 0.05m, assetAddress),
        new NonFungibleAsset("Azuki", 10.50m, assetAddress),
        new NonFungibleAsset("HELIX", 0.77m, assetAddress),
        new NonFungibleAsset("Rug Radio", 0.51m, assetAddress)
    };
    assets.AddRange(nonFungibleAssets);
}

void AssignAssetsToWallets()
{
    wallets[0].FungibleAssetsBalance.Add((assets[0].Address, 6));
    wallets[0].FungibleAssetsBalance.Add((assets[1].Address, 3));
    wallets[0].SupportedAssetsAddresses.Add(assets[0].Address);
    wallets[0].SupportedAssetsAddresses.Add(assets[1].Address);

    wallets[1].FungibleAssetsBalance.Add((assets[2].Address, 7));
    wallets[1].FungibleAssetsBalance.Add((assets[3].Address, 1));
    wallets[1].SupportedAssetsAddresses.Add(assets[2].Address);
    wallets[1].SupportedAssetsAddresses.Add(assets[2].Address);

    wallets[2].FungibleAssetsBalance.Add((assets[4].Address, 11));
    wallets[2].FungibleAssetsBalance.Add((assets[5].Address, 9));
    wallets[2].SupportedAssetsAddresses.Add(assets[4].Address);
    wallets[2].SupportedAssetsAddresses.Add(assets[5].Address);
    
    var tempEthereum = wallets[3] as EthereumWallet;
    tempEthereum.FungibleAssetsBalance.Add((assets[6].Address, 2));
    tempEthereum.FungibleAssetsBalance.Add((assets[7].Address, 5));
    tempEthereum.SupportedAssetsAddresses.Add(assets[6].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[7].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[8].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[9].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[2].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[11].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[13].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[16].Address);
    wallets[3] = tempEthereum;
    
    tempEthereum = wallets[4] as EthereumWallet;
    tempEthereum.FungibleAssetsBalance.Add((assets[8].Address, 8));
    tempEthereum.FungibleAssetsBalance.Add((assets[9].Address, 4));
    tempEthereum.SupportedAssetsAddresses.Add(assets[6].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[7].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[8].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[9].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[2].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[23].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[21].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[19].Address);
    wallets[4] = tempEthereum;
    
    tempEthereum = wallets[5] as EthereumWallet;
    tempEthereum.FungibleAssetsBalance.Add((assets[2].Address, 7));
    tempEthereum.FungibleAssetsBalance.Add((assets[6].Address, 2));
    tempEthereum.SupportedAssetsAddresses.Add(assets[6].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[7].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[8].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[9].Address);
    tempEthereum.SupportedAssetsAddresses.Add(assets[2].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[25].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[26].Address);
    tempEthereum.AddressesOfOwnedNonFungibleAssets.Add(assets[22].Address);
    wallets[5] = tempEthereum;
    
    var tempSolana = wallets[6] as SolanaWallet;
    tempSolana.FungibleAssetsBalance.Add((assets[1].Address, 2));
    tempSolana.FungibleAssetsBalance.Add((assets[6].Address, 8));
    tempSolana.SupportedAssetsAddresses.Add(assets[1].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[6].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[5].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[7].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[2].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[8].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[19].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[23].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[25].Address);
    wallets[6] = tempSolana;
    
    tempSolana = wallets[7] as SolanaWallet;
    tempSolana.FungibleAssetsBalance.Add((assets[5].Address, 13));
    tempSolana.FungibleAssetsBalance.Add((assets[7].Address, 3));
    tempSolana.SupportedAssetsAddresses.Add(assets[1].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[6].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[5].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[7].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[2].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[8].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[16].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[17].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[18].Address);
    wallets[7] = tempSolana;
    
    tempSolana = wallets[8] as SolanaWallet;
    tempSolana.FungibleAssetsBalance.Add((assets[2].Address, 6));
    tempSolana.FungibleAssetsBalance.Add((assets[8].Address, 2));
    tempSolana.SupportedAssetsAddresses.Add(assets[1].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[6].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[5].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[7].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[2].Address);
    tempSolana.SupportedAssetsAddresses.Add(assets[8].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[24].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[16].Address);
    tempSolana.AddressesOfOwnedNonFungibleAssets.Add(assets[19].Address);
    wallets[8] = tempSolana;
}

void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("\n 1 - Create wallet \n 2 - Access wallet \n 3 - Exit app \n \n Enter one of the specified values");
}

void PrintAccessWalletMenu()
{
    Console.WriteLine("\n Please choose what you want to do with the wallet: \n 1 - Access portfolio \n 2 - Transfer assets \n 3 - History of transactions \n 4 - Cancel transaction \n 5 - Return to previous menu \n");
}

void PrintBitcoinWallet(BitcoinWallet bitWallet)
{
    Console.WriteLine($"Total balance of the wallet: {bitWallet.ReturnTotalValueOfFungibleAssets(assets)} \n");
    Console.WriteLine("Fungible assets: \n");
    var allFungibleAssets = bitWallet.FungibleAssetsBalance
        .Select(item => assets.Find(x => x.Address.Equals(item.Address))).ToList();
        
    foreach (var fungibleAsset in allFungibleAssets.Select(item => item as FungibleAsset))
    {
        if (fungibleAsset is null) continue;
        var fungibleAssetBalance = bitWallet.FungibleAssetsBalance.Find(x => x.Address == fungibleAsset.Address)
            .Balance;
        Console.WriteLine($"Address: {fungibleAsset.Address} \n Name: {fungibleAsset.Name} \n Label: {fungibleAsset.Label} \n " +
                          $"Balance: {fungibleAssetBalance} \n Value: {fungibleAsset.Value} \n");
        if (fungibleAsset.ReturnPreviousValue(transactions) is 0m)
        {
            Console.WriteLine("\n Asset has no previous changes to its values! \n");
        }
        else
        {
            var previousValue = fungibleAsset.ReturnPreviousValue(transactions);
            Console.WriteLine(previousValue > fungibleAsset.Value
                ? $"\n Asset value ha dropped by: {(previousValue - fungibleAsset.Value) / 100} % \n"
                : $"\n Asset value ha increased by: {(fungibleAsset.Value - previousValue) / 100} % \n");
        }
    }
}

void PrintEthereumWallet(EthereumWallet ethWallet)
{
    Console.WriteLine($"Total balance of the wallet: {ethWallet.ReturnTotalValueOfAssets(assets)} \n");
    Console.WriteLine("Fungible assets: \n");
    var allFungibleAssets = ethWallet.FungibleAssetsBalance
        .Select(item => assets.Find(x => x.Address.Equals(item.Address))).ToList();
        
    foreach (var fungibleAsset in allFungibleAssets.Select(item => item as FungibleAsset))
    {
        if (fungibleAsset is null) continue;
        var fungibleAssetBalance = ethWallet.FungibleAssetsBalance.Find(x => x.Address == fungibleAsset.Address)
            .Balance;
        Console.WriteLine($"Address: {fungibleAsset.Address} \n Name: {fungibleAsset.Name} \n Label: {fungibleAsset.Label} \n " +
                          $"Balance: {fungibleAssetBalance} \n Value: {fungibleAsset.Value} \n");
        if (fungibleAsset.ReturnPreviousValue(transactions) is 0m)
        {
            Console.WriteLine("\n Asset has no previous changes to its values! \n");
        }
        else
        {
            var previousValue = fungibleAsset.ReturnPreviousValue(transactions);
            Console.WriteLine(previousValue > fungibleAsset.Value
                ? $"\n Asset value ha dropped by: {(previousValue - fungibleAsset.Value) / 100} % \n"
                : $"\n Asset value ha increased by: {(fungibleAsset.Value - previousValue) / 100} % \n");
        }
    }
    var allNonFungibleAssets = ethWallet.AddressesOfOwnedNonFungibleAssets
        .Select(item => assets.Find(x => x.Address.Equals(item))).ToList();
    foreach (var nonFungibleAsset in allNonFungibleAssets.Select(item => item as NonFungibleAsset))
    {
        if (nonFungibleAsset is null) continue;
        var fungibleAssetValue = assets.Find(x => x.Address == nonFungibleAsset.FungibleAssetAddress).Value;
        Console.WriteLine($"Address: {nonFungibleAsset.Address} \n Name: {nonFungibleAsset.Name} \n " +
                          $"Fungible asset value: {fungibleAssetValue} \n Value: {nonFungibleAsset.Value} \n");
        if (nonFungibleAsset.ReturnPreviousValue(transactions, assets) is 0m)
        {
            Console.WriteLine("\n Asset has no previous changes to its values! \n");
        }
        else
        {
            var previousValue = nonFungibleAsset.ReturnPreviousValue(transactions, assets);
            Console.WriteLine(previousValue > nonFungibleAsset.ReturnValue(assets)
                ? $"\n Asset value ha dropped by: {(previousValue - nonFungibleAsset.ReturnValue(assets)) / 100} % \n"
                : $"\n Asset value ha increased by: {(nonFungibleAsset.ReturnValue(assets) - previousValue) / 100} % \n");
        }
    }
}

void PrintSolanaWallet(SolanaWallet solWallet)
{
    Console.WriteLine($"Total balance of the wallet: {solWallet.ReturnTotalValueOfAssets(assets)} \n");
    Console.WriteLine("Fungible assets: \n");
    var allFungibleAssets = solWallet.FungibleAssetsBalance
        .Select(item => assets.Find(x => x.Address.Equals(item.Address))).ToList();
        
    foreach (var fungibleAsset in allFungibleAssets.Select(item => item as FungibleAsset))
    {
        if (fungibleAsset is null) continue;
        var fungibleAssetBalance = solWallet.FungibleAssetsBalance.Find(x => x.Address == fungibleAsset.Address)
            .Balance;
        Console.WriteLine($"Address: {fungibleAsset.Address} \n Name: {fungibleAsset.Name} \n Label: {fungibleAsset.Label} \n " +
                          $"Balance: {fungibleAssetBalance} \n Value: {fungibleAsset.Value} \n");
        if (fungibleAsset.ReturnPreviousValue(transactions) is 0m)
        {
            Console.WriteLine("\n Asset has no previous changes to its values! \n");
        }
        else
        {
            var previousValue = fungibleAsset.ReturnPreviousValue(transactions);
            Console.WriteLine(previousValue > fungibleAsset.Value
                ? $"\n Asset value ha dropped by: {(previousValue - fungibleAsset.Value) / 100} % \n"
                : $"\n Asset value ha increased by: {(fungibleAsset.Value - previousValue) / 100} % \n");
        }
    }
    var allNonFungibleAssets = solWallet.AddressesOfOwnedNonFungibleAssets
        .Select(item => assets.Find(x => x.Address.Equals(item))).ToList();
    foreach (var nonFungibleAsset in allNonFungibleAssets.Select(item => item as NonFungibleAsset))
    {
        if (nonFungibleAsset is null) continue;
        var fungibleAssetValue = assets.Find(x => x.Address == nonFungibleAsset.FungibleAssetAddress).Value;
        Console.WriteLine($"Address: {nonFungibleAsset.Address} \n Name: {nonFungibleAsset.Name} \n " +
                          $"Fungible asset value: {fungibleAssetValue} \n Value: {nonFungibleAsset.Value} \n");
        if (nonFungibleAsset.ReturnPreviousValue(transactions, assets) is 0m)
        {
            Console.WriteLine("\n Asset has no previous changes to its values! \n");
        }
        else
        {
            var previousValue = nonFungibleAsset.ReturnPreviousValue(transactions, assets);
            Console.WriteLine(previousValue > nonFungibleAsset.ReturnValue(assets)
                ? $"\n Asset value ha dropped by: {(previousValue - nonFungibleAsset.ReturnValue(assets)) / 100} % \n"
                : $"\n Asset value ha increased by: {(nonFungibleAsset.ReturnValue(assets) - previousValue) / 100} % \n");
        }
    }
}

void PrintPortfolio(Wallet wallet)
{
    if (wallet is BitcoinWallet bitWallet)
    {
        PrintBitcoinWallet(bitWallet);
    }

    if (wallet is EthereumWallet ethWallet)
    {
        PrintEthereumWallet(ethWallet);
    }

    if (wallet is SolanaWallet solWallet)
    {
        PrintSolanaWallet(solWallet);
    }
    Thread.Sleep(4000);
}

void TransferAsset(Wallet wallet)
{
    
}

void PrintHistoryOfTransactions(Wallet wallet)
{
    
}

void CancelTransaction(Wallet wallet)
{
    
}

void CreateNewWallet()
{
    Console.Clear();
    while (true)
    {
        Console.WriteLine("We will now create a new wallet, please enter one of the following numbers: \n 1 - Bitcoin \n 2 - Ethereum \n 3 - Solana \n");
        var flag = false;
        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                flag = true;
                wallets.Add(new BitcoinWallet());
                break;
            case "2":
                flag = true;
                wallets.Add(new EthereumWallet());
                break;
            case "3":
                flag = true;
                wallets.Add(new SolanaWallet());
                break;
            default:
                Console.WriteLine("ERROR: Invalid argument was given! Try Again! \n");
                Thread.Sleep(2000);
                Console.Clear();
                break;
        }

        if (flag)
        {
            break;
        }
    }
    Console.Clear();
}

void PrintAllWallets()
{
    Console.WriteLine("\n \n All currently existing wallets: \n \n");
    foreach (var item in wallets)
    {
        item.PrintWallet(assets, transactions);
    }
}
//Bilo bi pametno da unos walleta prebacis u zasebnu funkciju
void AccessWallet()
{
    Console.Clear();
    PrintAllWallets();
    Console.WriteLine("\n Enter which wallet you want to access: \n");
    var walletAddress = Guid.Parse(Console.ReadLine() ?? string.Empty);
    var address = walletAddress;
    if (wallets.Find(x => x.Address.Equals(address)) is null)
    {
        while (true)
        {
            Console.WriteLine("\n Previous address invalid! Please enter again! \n");
            walletAddress = Guid.Parse(Console.ReadLine() ?? string.Empty);
            var address1 = walletAddress;
            if (wallets.Find(x => x.Address.Equals(address1)) is not null)
            {
                break;
            }
        }
    }
    var wallet = wallets.Find(x => x.Address.Equals(walletAddress));
    PrintAccessWalletMenu();
    Console.WriteLine("\n Please select an option: \n");
    var input = Console.ReadLine();
    var flag = false;
    while (true)
    {
        switch (input)
        {
            case "1":
                PrintPortfolio(wallet);
                flag = true;
                break;
            case "2":
                TransferAsset(wallet);
                flag = true;
                break;
            case "3":
                PrintHistoryOfTransactions(wallet);
                flag = true;
                break;
            case "4":
                CancelTransaction(wallet);
                flag = true;
                break;
            case "5":
                flag = true;
                break;
            default:
                Console.WriteLine("\n ERROR: Wrong input given! Try Again!\n");
                input = Console.ReadLine();
                break;
        }

        if (flag)
        {
            break;
        }
    }
    Console.Clear();
}

void Start()
{
    AppendNonFungibleAssets();
    AssignAssetsToWallets();
    var flag = false;
    while (true)
    {
        PrintMenu();
        var input = Console.ReadLine();
        switch (input)
        {
            case "1":
                CreateNewWallet();
                break;
            case "2":
                AccessWallet();
                break;
            case "3":
                flag = true;
                break;
            default:
                Console.WriteLine("\n ERROR: Wrong input was given! \n");
                Thread.Sleep(2000);
                break;
        }

        if (!flag) continue;
        Console.WriteLine("\n \n Exiting app! \n \n");
        break;
    }
}

Start();
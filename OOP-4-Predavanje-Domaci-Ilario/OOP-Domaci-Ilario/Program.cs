
using OOP_Domaci_Ilario.Asset;
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

var fungibleAssetPriceHistory = new List<(Guid address, DateTime date, decimal value)>();

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

        if (flag is true)
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
        Console.WriteLine(item.Address);
    }
}

void AccessWallet()
{
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

        if (flag is true)
        {
            Console.WriteLine("\n \n Exiting app! \n \n");
            break;
        }
    }
}

Start();
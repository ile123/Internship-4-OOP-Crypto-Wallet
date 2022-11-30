// See https://aka.ms/new-console-template for more information

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;
using OOP_Domaci_Ilario.Wallet;

var wallets = new List<Wallet>()
{
    new BitcoinWallet(),
    new SolanaWallet(),
    new BitcoinWallet(),
    new EthereumWallet(),
    new SolanaWallet(),
    new BitcoinWallet(),
    new EthereumWallet(),
    new SolanaWallet(),
    new EthereumWallet()
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
    new NonFungibleAsset("CryptoPunks", 77810.40m),
    new NonFungibleAsset("Pre-Process", 7041.84m),
    new NonFungibleAsset("Mutant Ape Yacht Club", 17183.13m),
    new NonFungibleAsset("CLONE X", 11412.19m),
    new NonFungibleAsset("KILLABEARS", 3618.18m),
    new NonFungibleAsset("The Memes", 337.18m),
    new NonFungibleAsset("ENS", 12.97m),
    new NonFungibleAsset("Friendship Bracelets", 337.18m),
    new NonFungibleAsset("Otherdeed for Otherside", 1.31m),
    new NonFungibleAsset("Dreamy", 51.87m),
    new NonFungibleAsset("Azuki", 13811.35m),
    new NonFungibleAsset("CryptoDucks", 51.87m),
    new NonFungibleAsset("HELIX", 1089.35m),
    new NonFungibleAsset("Valhalla", 907.79m),
    new NonFungibleAsset("Genuine Undead", 778.10m),
    new NonFungibleAsset("Bored Ape Yacht Club", 90052.57m),
    new NonFungibleAsset("Pudgy Penguins", 4149.89m),
    new NonFungibleAsset("DEGEN TOONZ", 778.10m),
    new NonFungibleAsset("1337 skulls", 194.53m),
    new NonFungibleAsset("Bruh Pills", 103.75m),
};

var transactions = new Lazy<Transaction>();

void Start()
{
    
}

Start();
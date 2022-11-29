// See https://aka.ms/new-console-template for more information

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;
using OOP_Domaci_Ilario.Wallet;

//Console.WriteLine("Hello, World!");

var wallet = new BitcoinWallet();
var wallet2 = new EthereumWallet();
var wallet3 = new SolanaWallet();

var fungibleAsset = new FungibleAsset("Bitcoin", decimal.One, "BTC");
var nonFungibleAsset = new NonFungibleAsset("Bored Ape Yacht Club", Decimal.Zero);

var fungibleAssetTransaction = new FungibleAssetTransaction(Guid.NewGuid(), Guid.NewGuid(),
    Guid.NewGuid(), Decimal.One, Decimal.One, Decimal.One, decimal.One);
var nonFungibleAssetTransaction = new NonFungibleAssetTransaction(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());

Console.WriteLine(wallet.GetAddress());
Console.WriteLine(wallet2.GetAddress());
Console.WriteLine(wallet3.GetAddress());

Console.WriteLine(fungibleAsset.GetValue());
Console.WriteLine(nonFungibleAsset.GetNonFungibleAsset());

Console.WriteLine(fungibleAssetTransaction.GetTransactionId());
Console.WriteLine(nonFungibleAssetTransaction.GetTransactionId());


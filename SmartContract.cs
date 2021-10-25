// using ABI.Contracts.fusez.ContractDefinition;
// using Nethereum.JsonRpc.UnityClient;
// using System.Collections.Generic;
// using UnityEngine;

// public class SmartContract : MonoBehaviour {
//     private string url = "https://kovan.infura.io/v3/e0f9e0acea7f4e2a90edba953bbf1277";
//     private string account = "0xbd53Ef09C8e5C31004d57E7D297f221C08560FF1";
//     private string privateKey = "c566b17567c731f2889ac7fe772d00d4f66e25ca00ae00152cd99bbe4bd0a3c6";
//     private string contractAddress = "0xb5d0F518805264Ff1D17E8102f9E4121B2c11DE7";
        

//     // Use this for initialization
//     void Start ()
//     {
//     }

//     public void CallBalance() {
//         StartCoroutine(Balance());
//     }
//     public IEnumerator Balance()
//     {
//         //Query request using our acccount and the contracts address (no parameters needed and default values)
//         var queryRequest = new QueryUnityRequest<BalanceOfFunction, BalanceOfFunctionOutput>(url, account);
//         yield return queryRequest.Query(new BalanceOfFunction(){Account = account}, contractAddress);

//         //Getting the dto response already decoded
//         var dtoResult = queryRequest.Result;
//         Debug.Log(dtoResult.ReturnValue1);

//     }
//     public IEnumerator Mint()
//     {
//         var transactionTransferRequest = new TransactionSignedUnityRequest(url, privateKey);
//         transactionTransferRequest.UseLegacyAsDefault = true;
//         var transactionMessage = new MintFunction{};

//         yield return transactionTransferRequest.SignAndSendTransaction(transactionMessage, deploymentReceipt.ContractAddress);
//         var transactionTransferHash = transactionTransferRequest.Result;

//         Debug.Log("Transfer txn hash:" + transactionHash);

//         TransactionReceiptPollingRequest transactionReceiptPolling  = new TransactionReceiptPollingRequest(url);
//         yield return transactionReceiptPolling.PollForReceipt(transactionTransferHash, 2);
//         var transferReceipt = transactionReceiptPolling.Result;

//         Debug.Log("Minted");
//     }
  
// }

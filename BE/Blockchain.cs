using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace BE
{
    public class Blockchain
    {
        private List<Transaction> _currentTransactions = new List<Transaction>();
        private List<Block> _chain = new List<Block>();
        private List<Node> _nodes = new List<Node>();
        private Block _lastBlock => _chain.Last();

        public string NodeId { get; private set; }

        //ctor
        public Blockchain()
        {
            NodeId = Guid.NewGuid().ToString().Replace("-", "");
            CreateFirstBlock(proof: 100, previousHash: "1"); //genesis block
        }

        private bool IsValidChain(List<Block> chain)
        {
            Block block = null;
            Block lastBlock = chain.First();
            int currentIndex = 1;
            while (currentIndex < chain.Count)
            {
                block = chain.ElementAt(currentIndex);
                Debug.WriteLine($"{lastBlock}");
                Debug.WriteLine($"{block}");
                Debug.WriteLine("----------------------------");

                //Check that the hash of the block is correct
                if (block.PreviousHash != GetHash(lastBlock))
                    return false;

                //Check that the Proof of Work is correct
                if (!IsValidProof(lastBlock.Proof, block.Proof, lastBlock.PreviousHash))
                    return false;

                lastBlock = block;
                currentIndex++;
            }

            return true;
        }

        private bool ResolveConflicts(List<Blockchain> nodos)
        {
            List<Block> newChain = null;
            int maxLength = _chain.Count;

            foreach (Blockchain chain2 in nodos)
            {
                var model = new
                {
                    chain = new List<Block>(),
                    length = 0
                };

                List<Block> chain = new List<Block>();
                chain = chain2.GetFullChain();

                if (IsValidChain(chain) && chain.Count > _chain.Count)
                {
                    maxLength = chain.Count;
                    newChain = chain;
                }

            }

            if (newChain != null)
            {
                _chain = newChain;
                return true;
            }

            return false;
        }

        private Block CreateFirstBlock(int proof, string previousHash = null)
        {

                var block = new Block
                {
                    Index = _chain.Count,
                    Timestamp = DateTime.UtcNow,
                    Transactions = _currentTransactions.ToList(),
                    Proof = proof,
                    PreviousHash = previousHash ?? GetHash(_chain.Last())
                };

                _currentTransactions.Clear();
                _chain.Add(block);
                return block;


        }

        private Block CreateNewBlock(int proof, string previousHash = null)
        {
            if (_currentTransactions.Count > 0)
            {
                var block = new Block
                {
                    Index = _chain.Count,
                    Timestamp = DateTime.UtcNow,
                    Transactions = _currentTransactions.ToList(),
                    Proof = proof,
                    PreviousHash = previousHash ?? GetHash(_chain.Last())
                };

                _currentTransactions.Clear();
                _chain.Add(block);
                return block;
            }
            else
            {
                return null;
            }

        }

        private int CreateProofOfWork(int lastProof, string previousHash)
        {
            int proof = 0;
            while (!IsValidProof(lastProof, proof, previousHash))
                proof++;

            return proof;
        }

        private bool IsValidProof(int lastProof, int proof, string previousHash)
        {
            string guess = $"{lastProof}{proof}{previousHash}";
            string result = GetSha256(guess);
            return result.StartsWith("0000");
        }

        private string GetHash(Block block)
        {
            string blockText = JsonConvert.SerializeObject(block);
            return GetSha256(blockText);
        }

        private string GetSha256(string data)
        {
            var sha256 = new SHA256Managed();
            var hashBuilder = new StringBuilder();

            byte[] bytes = Encoding.Unicode.GetBytes(data);
            byte[] hash = sha256.ComputeHash(bytes);

            foreach (byte x in hash)
                hashBuilder.Append($"{x:x2}");

            return hashBuilder.ToString();
        }

        public Block Mine()
        {
            int proof = CreateProofOfWork(_lastBlock.Proof, _lastBlock.PreviousHash);

            //CreateTransaction(sender: "0", recipient: NodeId, amount: 1);
            Block block = CreateNewBlock(proof /*, _lastBlock.PreviousHash*/);
            return block;
        }

        public List<Block> GetFullChain()
        {
            return _chain;
        }

        public List<Transaction> GetBlockTransactions(int index)
        {
            foreach (Block block in _chain)
            {
                if (block.Index == index)
                    return block.Transactions;
            }
            return null;
        }

        public string Consensus(List<Blockchain> nodos)
        {
            bool replaced = ResolveConflicts(nodos);
            string message = replaced ? "was replaced" : "is authoritive";
            return message;
        }

        public int CreateTransaction(string sender, string recipient, int amount)
        {
            var transaction = new Transaction
            {
                Sender = sender,
                Recipient = recipient,
                Amount = amount
            };

            _currentTransactions.Add(transaction);

            return _lastBlock != null ? _lastBlock.Index + 1 : 0;
        }
    }
}


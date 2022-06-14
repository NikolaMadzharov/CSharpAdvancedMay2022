using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }

        public List<Stock> Portfolios { get; private set; } = new List<Stock>();
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string  BrokerName { get; set; }

        public int Count => this.Portfolios.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest > 10000) 
            {
                this.MoneyToInvest -= stock.PricePerShare;
            }

            Portfolios.Add(stock);
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            var company = this.Portfolios.Where(company => company.CompanyName == companyName).FirstOrDefault();

            if (company == null)
            {
                return $"{companyName} does not exist.";
            }

            if (company.PricePerShare > sellPrice)
            {
                return $"Cannot sell {companyName}.";
            }

            Portfolios.Remove(company);
            return $"{companyName} was sold.";
        }

        public Stock FindStock(string companyName)
        {
            var company = this.Portfolios.FirstOrDefault(company => company.CompanyName == companyName);

            if (company == null)
            {
                return null;
            }
            else
            {
                return company;
            }
        }

        public Stock FindBiggestCompany()
        {
            var company = this.Portfolios.Max(m => m.MarketCapitalization);

            if (company == null)
            {
                return null;
            }

            var expesiveCompany = this.Portfolios.Where(expesiveCompany => expesiveCompany.MarketCapitalization == company).FirstOrDefault();

            return expesiveCompany;
        }

        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks: ");

            foreach (var portfolio in Portfolios)
            {
                sb.AppendLine($"{portfolio}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
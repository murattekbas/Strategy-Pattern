using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    //STRATEGY PATTERN BENEFITS
    //More extensible, object oriented and dynamic implemantation
    //easily add new strategies without affecting existing ones
    //cleaner approach with single responsibility in mind
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}

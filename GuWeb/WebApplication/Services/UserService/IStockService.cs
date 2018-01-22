using BusinessService.Entities;
using GuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService {
    public interface IStockService {

        int AddStock(List<Stock> stocks);

        int AddCompanyProfile(List<CompanyProfile> profiles);

        IEnumerable<AutoCompleteModel> SearchStock(string kw);

        Stock GetStockByCode(string code);

        IEnumerable<Stock> GetStockList();
    }
}

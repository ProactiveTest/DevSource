using System;

    public interface IStockService : ITransientService
    {
        public Task<PaginationResponse<StockDto>> GetAllStock();

    }

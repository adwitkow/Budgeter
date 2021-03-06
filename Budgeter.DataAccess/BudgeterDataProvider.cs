// This file is part of Budgeter project <https://github.com/adwitkow/Budgeter>
// Copyright (C) 2021  Adam Witkowski <https://github.com/adwitkow/>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Threading.Tasks;
using Budgeter.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Budgeter.DataAccess
{
    public class BudgeterDataProvider
    {
        private readonly BudgeterDbContext dbContext;

        public BudgeterDataProvider(BudgeterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync()
        {
            return await this.dbContext.Transactions.ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await this.dbContext.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return await this.dbContext.Locations.ToListAsync();
        }

        public async Task<IEnumerable<Source>> GetSourcesAsync()
        {
            return await this.dbContext.Sources.ToListAsync();
        }

        public async Task<Transaction> GetTransactionByIdAsync(int id)
        {
            return await this.dbContext.Transactions.SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task<int> AddTransactionAsync(Transaction transaction)
        {
            this.dbContext.Transactions.Add(transaction);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> AddTransactionRangeAsync(IEnumerable<Transaction> transactions)
        {
            this.dbContext.Transactions.AddRange(transactions);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> AddCategoryAsync(Category category)
        {
            this.dbContext.Categories.Add(category);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> AddLocationAsync(Location location)
        {
            this.dbContext.Locations.Add(location);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> AddSourceAsync(Source source)
        {
            this.dbContext.Sources.Add(source);
            return await this.dbContext.SaveChangesAsync();
        }

        public async Task<int> RemoveTransactionAsync(Transaction transaction)
        {
            this.dbContext.Transactions.Remove(transaction);
            return await this.dbContext.SaveChangesAsync();
        }
    }
}

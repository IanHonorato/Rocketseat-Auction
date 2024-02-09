﻿using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Repositories
{
    public class RocketseatAuctionDbContext : DbContext
    {
        public RocketseatAuctionDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
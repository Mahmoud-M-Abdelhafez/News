﻿using News.DTOs;
using News.Models;

namespace News.Interfaces
{
    public interface IArticleRepository
    {
        public List<Article> GetAll();
        public Article GetById(int id);
        public List<Article> GetByName(string ArticleTitle);
        public Task AddAsync(ArticleDTO articleDto, IFormFile Image);
        public void Update(int ArticleId,ArticleDTO articleDto);
        public void Delete(int ArticleId);
    }
}

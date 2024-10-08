﻿using hacker.news.api.repositories.HackerNewsRepository.Models;

namespace hacker.news.api.repositories.HackerNewsRepository
{
    /// <summary>
    /// Repository Interface
    /// </summary>
    public interface IHackerNewsRepository
    {
        /// <summary>
        /// Retrieves news details by news id
        /// </summary>
        /// <param name="storyId">Id of story</param>
        /// <returns>Return HackerNewsResponse</returns>
        public Task<HackerNewsResponse> GetHackerNewsById(int storyId);
        /// <summary>
        /// Retrieves top news ids
        /// </summary>
        /// <returns>Return List of top news ids</returns>
        public Task<IEnumerable<int>> GetTopHackerNewsIds();
    }
}

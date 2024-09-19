using Entities;

namespace RepositoryContracts;

public interface ICommentRepository
{
    Comment FindCommentById(int id);
    Task<Comment> AddAsync(Comment comment);
    Task UpdateAsync(Comment comment);
    Task DeleteAsync(int id);
    Task<Comment> GetSingleAsync(int id);
    IQueryable<Comment> GetMany();
    Task LikeAsync (Comment comment);
    Task DisLikeAsync (Comment comment);
    Task<List<Comment>> GetCommentsByPostIdAsync(int postId);
}
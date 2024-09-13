// See https://aka.ms/new-console-template for more information
using CLI.UI;
using InMemoryRepositories;
using RepositoryContracts;

Console.WriteLine("Starting CLI app...");
IUserRepository userRepository = new UserInMemoryRepository();
ICommentRepository commentRepository = new CommentInMemoryRepository();
IPostRepository postRepository = new PostInMemoryRepository();

var cliApp = new CLIApp(userRepository, commentRepository, postRepository);
await cliApp.StartAsync();

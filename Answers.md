## Assignemt HiQ

The RESTful web api should be able to recieve a text file, serach this for most common word, surround it with 'foo' and 'bar' and return modified text to user. 


The techniques used to solve this task is ASP.NET Core. The framework has all that this task require, also because I am on a mac. 
I am using repository patterna to separate logic into business and data logic, service and repository repsp. 
## perhaps model representing file? In that case text, perhaps number of occurences, most common word. 
in that case, also use Dto and Automapper to map Model File to FileDto
- Extension Automapper is used to map modle to DTO

The project will consist of following structure;
 - a FileController that will handle the request flow, inheriting ControllerBase class. Base class is chosen because the api does not need a view. 
    - Dependency injection for binding service and mapper to controller
    - user input validation
 - an interface IFileService that will define those function required to handle business logic
 - a FileService handling all business logic, e.g. Handling mapping to Dto returning essential data to client.
    - Dependency injection to bind fileRepo to service
 - a IFileRepo defining those functions needed to process data, in this case reding file from stream, determining most common word and modify text, returning modified result to service. 
 - a model, File that contains properties refpresenting a file, (in case solution is to be upscaled)
 - Dependency injection in 'Startup.cs' ; 
    - FileModel mapped to FileDto
    Add scoped;
    - IFileService to FileService
    - IFileRepo to FileRepo
 










 

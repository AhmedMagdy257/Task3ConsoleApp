using Microsoft.EntityFrameworkCore;
using Task3.Context;
using Task3.ViewModel;

TaskDBContext DB = new TaskDBContext();
GetData Data = new GetData(DB);
var result=await Data.asynclist();
foreach (var item in result.Authors)
{
    Console.WriteLine($"Author : {item.Name} && Age : {item.Age} && No.Books : {item.NumberOfBooks}");
}
foreach (var item in result.Books)
{
    Console.WriteLine($"Book Name: {item.Name} && Publish Date : {item.PublishDate.Year} && Author Name :{item.Author.Name}");
}
using Lesson_11_12_Exception_Abstact.Exceptions;
using Lesson_11_12_Exception_Abstact.Helpers;
using Lesson_11_12_Exception_Abstact.Models;

// Person person;
// Console.WriteLine(person.Name); // Compile time error



// Person person2 = null!;
// Console.WriteLine(person2.Name); // Run time error


// Person person3 = new Person();
// Console.WriteLine(person3.Name);

// ///////////////////////////////////////////////////////////

/// Exception


// keywords

// try                      +
// catch                    +
// throw                    +
// when ( filterasiya )     +
// re throw					+
// finally
// custom exception         +


// Simple version

// try
// {
//     int x = 2000;
// 
//     Console.WriteLine(x / 0);
// 
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ex message: {ex.Message}");
// }


// Ierarxic

// try
// {
//     int x = 2000;
// 
//     Console.WriteLine(x / 0);
// }
// catch(DivideByZeroException dex)
// {
//     Console.WriteLine("Sifira bolme emeliyyati yoxdur");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ex message: {ex.Message}");
// }


// 

// try
// {
//     throw new ArgumentNullException();
// }
// catch(ArgumentNullException anex)
// {
//     Console.WriteLine($"ArgumentEx: {anex.Message}");
// }
// catch (SystemException syex)
// {
//     Console.WriteLine($"System exception: {syex.Message}");
// }
// catch 
// {
//     Console.WriteLine($"Exception occured");
// }

/////////////////////////////////
/// 

// try
// {
//     Dangerous.DangerousMethod();
// }
// catch (DivideByZeroException dex)
// {
//     Console.WriteLine($"ArgumentEx: {dex.Message}");
// }
// catch (SystemException syex)
// {
//     Console.WriteLine($"System exception: {syex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Exception: {ex.Message}");
// }


// ///////////////////////////////////////////////////////////
// When keyword

// int[] number = { 1, 2, 3, 4, 5 };
// 
// int index = 100;
// 
// try
// {
//     Console.WriteLine(number[index]);
// }
// catch(IndexOutOfRangeException iex) when (index < 0)
// {
//     Console.WriteLine("Siz menfi index-e muraciet edirsiz...");
// }
// catch (IndexOutOfRangeException iex) when (index > number.Length)
// {
//     Console.WriteLine("Siz arrayin uzunlugundan sonraki index-e muraciet edirsiz...");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ex message: {ex.Message}");
// }


// ///////////////////////////////////////////////////////////
// re throw


// try
// {
// 	try
// 	{
// 		int number = 50;
//         Console.WriteLine(number / 0);
// 	}
// 	catch
// 	{
// 		throw new Exception("Sifira bolme olmaz...");
// 	}
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Exeption occured: {ex.Message}");
// }

// ///////////////////////////////////////////////////////////
// Custom Exception

// try
// {
// 	throw new CustomException("Daxil edilen username ve ya password yanlisdir");
// 	throw new CustomException(401, "Daxil edilen username ve ya password yanlisdir");
// }
// catch (CustomException cex)
// {
//     Console.WriteLine($"Status Code: {cex.StatusCode}");
//     Console.WriteLine($"EX: {cex.Message}");
// }


// ///////////////////////////////////////////////////////////
// Finally 

var httpClient = new HttpClient();

try
{
    var data = await httpClient.GetStringAsync("https://www.google.com");
    Console.WriteLine(data);

}
catch (Exception ex)
{
    Console.WriteLine($"Exception message: {ex.Message}");
}
finally
{
    httpClient.Dispose();    
}


using var httpClient2 = new HttpClient();

using var httpClient3 = new HttpClient()
{

};


/// Finally Monitor
/// 

// try
// {
//     Monitor.Enter(new object());
// }
// finally
// {
//     Monitor.Exit(new object());
// }

////////////////////////////////////////////////





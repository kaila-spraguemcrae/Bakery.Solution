<br>
<h1 align = "center">
<b> Pierre's Bakery </b>
</h1>

<p align = "center">
A basic C# console application for Pierre's Bakery, 12.11.2020
</p>

<p align = "center">
 By <b>Kaila Sprague McRae</b>
 </p>

--------------------

## 📖  Description

This console application will allow a user to specify how many loaves of bread and how many pastries they want to order, andwill show a total cost. This application has build in 'deals' which change the price of the baked goods according to how many the user has selected. This is the first independent project in the C# module.

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3
- .NET Core v2.2
- dotnet script, REPL

-------------------

## Specs

<details>

| Test | Input | Output |
| :------------- | :------------- | :------------- |
| **Bread**|||
| Should create an instance of Bread | Assert.AreEqual(typeof(Bread), newBread.GetType()); | true |
| Should create an instance of Bread Price | newBread.Price | $5 |
| Should create an instance of Bread Quantity | quantity = 5 | newBread.Quantity = 5 |
| Should create an instance of Bread Total | newBread.Total | $0 |
| **BreadTotal()**|||
| Should Calculate the total of Bread | quantity = 5 | $20 |
| **Pastry**|||
| Should create an instance of Pastry | Assert.AreEqual(typeof(Pastry), newPastry.GetType()); | true |
| Should create an instance of Pastry Price | newPastry.Price | $2 |
| Should create an instance of Pastry Quantity | quantity = 5 | newPastry.Quantity = 5 |
| Should create an instance of Pastry Total | newPastry.Total | $0 |
| **PastryTotal()**|||
| Should Calculate the total of Pastry| quantity = 5 | $20 |
| **Order()**|||
| Should create an instance of Order | Assert.AreEqual(typeof(Order), newOrder.GetType()); | true |
| Should create an instance of Order BreadTotal | Assert.AreEqual(breadTotal, result); | true |
| Should create an instance of Order PastryTotal | Assert.AreEqual(pastryTotal, result) | true |
| Should return empty Order List |CollectionAssert.AreEqual(newList, result) | true |
| Should return Order List | CollectionAssert.AreEqual(newList, result);| true |

</details>

-------------------

## 🔧 Setup/Installation Requirements

### Open Locally

Go to my GitHub repository here, [https://guthub.com/kaila.spraguemcrae/bakery](https://guthub.com/kaila.spraguemcrae/bakery), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### Necessary Specifications

- To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)

* Please note this project uses .NET Core v2.2

#### To clone (my prefered method):
1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/kaila-spraguemcrae/bakery`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'Bakery' folder (`cd Bakery`) in the command line and run `dotnet run`.
2. At this point the console application should run as expected. 

#### Running tests:

1. To run MS tests you will need to navigate to the 'Bakery.Tests' folder (`cd Bakery.Tests`) in the command line and then run `dotnet restore`. 
2. You should now see 'obj' folders in both the 'Bakery.Tests' folder and 'Bakery' folder.
3. At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the Bakery.Tests folder). 

--------------------------

## 🐛 Known Bugs

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:kaila.sprague@icloud.com).

---------------------------

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2020 Kaila Sprague McRae
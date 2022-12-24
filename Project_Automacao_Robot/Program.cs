using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Diagnostics;

//Definir o driver do Browser a ser utilizado na aplicação atual criando uma nova instancia de Driver
var driver = new ChromeDriver();

//Adiciona uma URL para ser acessada no Web Driver e navega até ela pelo método
driver.Navigate().GoToUrl("https://google.com.br");

await Task.Delay(3000);

//Find para encontrar o elemento ná pagina atual navegada e SendKeys para executar ações no elemento encontrado
driver.FindElement(By.Name("q")).SendKeys("Como Aprender a programar?" + Keys.Enter);

//Cria uma task para gerar  um timeOut
await Task.Delay(5000);
//Fechando a janela
driver.Quit();

//Environment.Exit(0);
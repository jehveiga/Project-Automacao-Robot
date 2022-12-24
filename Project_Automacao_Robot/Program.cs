using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

//Definir o driver do Browser a ser utilizado na aplicação atual criando uma nova instancia de Driver
var driver = new ChromeDriver();

//Adiciona uma URL para ser acessada no Web Driver e navega até ela pelo método
driver.Navigate().GoToUrl("https://google.com.br");

//Find para encontrar o elemento ná pagina atual navegada e SendKeys para executar ações no elemento encontrado
driver.FindElement(By.Name("q")).SendKeys("Como Aprender a programar?" + Keys.Enter);

//Fechando a janela
//driver.Quit();
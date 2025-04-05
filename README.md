# 🧠 Verificador de CPF

Este projeto foi o **meu primeiro contato com a tecnologia ASP.NET Core MVC**, e serviu como uma excelente oportunidade de aprendizado.  
Ele representa um passo importante na minha jornada com desenvolvimento web utilizando **.NET**, e me ajudou a entender melhor como organizar um projeto com MVC, ViewModel, Razor Pages e estilização com CSS e JavaScript.

---

## ✅ O que esse projeto faz?

- Recebe um CPF digitado pelo usuário
- Aplica o algoritmo de validação
- Informa se o CPF é **válido** ou **inválido**
- Possui modo escuro 🌙 e máscara de CPF
- Não salva histórico no input
- Tudo numa única página!

---

## 🚀 Por que usar ASP.NET Core MVC?

- 🔧 Estrutura clara e separada entre **Model**, **View** e **Controller** (MVC)
- ⚡ Rápido e com ótima performance
- 🔒 Segurança robusta por padrão
- 🌐 Fácil integração com HTML, CSS, JavaScript e bibliotecas modernas
- 📦 Ideal para aplicações escaláveis e organizadas

---

## 📂 Estrutura de Pastas

| Pasta / Arquivo               | Função                                                                 |
|------------------------------|------------------------------------------------------------------------|
| `Controllers/CPFController.cs` | Controla o fluxo da aplicação, recebe os dados do input e chama a lógica |
| `Models/CPFViewModel.cs`       | Contém as propriedades do CPF e o resultado da verificação              |
| `Views/CPF/Index.cshtml`       | Página Razor (HTML) que mostra o formulário, botão, e o resultado       |
| `wwwroot/`                     | Onde ficam os arquivos estáticos como CSS, JS e imagens                 |
| `appsettings.json`             | Arquivo de configuração da aplicação                                   |
| `Program.cs` / `Startup.cs`    | Inicializam e configuram o projeto ASP.NET Core                        |

---

## 📊 Tecnologias usadas no projeto

![Gráfico de Tecnologias](https://i.imgur.com/FUea8ni.png)

---

## 🛠 Tecnologias e Frameworks

- `C#`
- `ASP.NET Core MVC`
- `HTML`, `CSS`
- `JavaScript` (máscara e modo escuro)

---

## ✍️ Exemplo de uso

Digite: `123.456.789-09`  
Resultado: **Inválido**

Digite: `529.982.247-25`  
Resultado: **Válido**

---

## 🚀 Como rodar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/verificador-cpf.git

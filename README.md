# StudentManagement
API desenvolvida em ASP.NET Core para gerenciamento de estudantes utilizando o padrão de arquitetura **Ports and Adapters (Arquitetura Hexagonal)**.  
O objetivo do projeto é demonstrar a separação clara entre regras de negócio e tecnologias externas.

---

## 📌 Estrutura do Projeto

O projeto está organizado nas seguintes camadas:

Domain </br>
├─ Entities
│ └─ Student.cs
└─ Interfaces
└─ IStudentRepository.cs

Application
└─ Services
└─ StudentService.cs

Infrastructure
└─ Repositories
└─ StudentRepository.cs

API
└─ Controllers
└─ StudentController.cs

### Domain
Contém os elementos centrais da aplicação.

- **Student**: entidade que representa um aluno.
- **IStudentRepository**: interface que define os métodos de acesso aos dados.

### Application
Contém a lógica de negócio da aplicação.

- **StudentService**: responsável por aplicar as regras de negócio antes de salvar ou consultar dados.

### Infrastructure
Contém as implementações concretas.

- **StudentRepository**: implementação do repositório utilizando uma lista em memória.

### API
Camada responsável por expor os endpoints HTTP.

- **StudentController**: recebe requisições e chama os serviços da aplicação.

---

## 📌 Regras de Negócio

As validações são implementadas manualmente no método **Enroll** da classe `StudentService`.

- O campo **FirstName** não pode ser nulo ou vazio.
- O campo **FirstName** deve ter no máximo **50 caracteres**.
- O **email** deve terminar com `@faculdade.edu`.
- O **email deve ser único** (não pode existir outro estudante com o mesmo email).

---

## 📌 Injeção de Dependência

As dependências são registradas no `Program.cs`:

```csharp
builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

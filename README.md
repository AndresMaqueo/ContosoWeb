# ContosoWeb – ASP.NET Core Web API

## 📌 Overview

**ContosoWeb** es una **ASP.NET Core Web API** diseñada como proyecto base para demostrar buenas prácticas en:

- diseño de APIs
- documentación temprana
- arquitectura ligera (C4 Model)
- control de versiones desde el inicio

El objetivo del proyecto es servir como **laboratorio técnico** y **base extensible** para escenarios reales de desarrollo backend en .NET.

---

## 🧩 Architecture

El sistema sigue una **vista C4 – Context** simple y clara:

- **User**  
  Actor que consume la API vía HTTP.

- **ContosoWeb API**  
  Aplicación ASP.NET Core Web API que expone endpoints REST.

- **Windows 11 Host**  
  Entorno donde la aplicación se ejecuta actualmente (local development).

📄 Diagrama C4 Context:  
`docs/architecture/C4-Context-ContosoWeb.drawio`

---

## ⚙️ Technology Stack

- ASP.NET Core Web API
- C#
- Swagger / OpenAPI (OAS 3.0)
- Git & GitHub
- diagrams.net (draw.io)

---

## 🚀 Running the Application (Local)

### Prerequisites
- .NET SDK
- Git

### Run
```bash
dotnet restore
dotnet run
